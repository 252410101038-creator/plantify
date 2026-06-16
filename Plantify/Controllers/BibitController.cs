using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using plantify.Database;
using plantify.Models;

namespace plantify.Controllers
{
    public class BibitController
    {
        public List<string> GetKategori()
        {
            List<string> kategoriList = new List<string>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT DISTINCT jenis_bibit FROM bibit ORDER BY jenis_bibit";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        kategoriList.Add(reader["jenis_bibit"].ToString());
                }
            }

            return kategoriList;
        }

        public DataTable GetKatalog(string keyword = "", string kategori = "")
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"SELECT
                    id_bibit,
                    nama_bibit,
                    nama_bibit AS ""Nama Bibit"",
                    jenis_bibit,
                    jenis_bibit AS ""Kategori"",
                    harga,
                    TO_CHAR(harga, 'FM999,999,999') AS ""Harga (Rp)"",
                    stok,
                    stok AS ""Stok"",
                    deskripsi,
                    gambar
                 FROM bibit
                 WHERE stok > 0";

                if (!string.IsNullOrEmpty(keyword))
                    query += " AND LOWER(nama_bibit) LIKE LOWER(@keyword)";

                if (!string.IsNullOrEmpty(kategori) && kategori != "Semua Kategori")
                    query += " AND jenis_bibit = @kategori";

                query += " ORDER BY nama_bibit";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(keyword))
                        cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                    if (!string.IsNullOrEmpty(kategori) && kategori != "Semua Kategori")
                        cmd.Parameters.AddWithValue("@kategori", kategori);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public Bibit GetDetailBibit(int id)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"SELECT nama_bibit, jenis_bibit, deskripsi, 
                                 harga, stok
                                 FROM bibit WHERE id_bibit = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Bibit(
                                id,
                                reader["nama_bibit"].ToString(),
                                reader["jenis_bibit"].ToString(),
                                reader["deskripsi"].ToString(),
                                Convert.ToDecimal(reader["harga"]),
                                Convert.ToInt32(reader["stok"]),
                                ""
                            );
                        }
                    }
                }
            }
            return null;
        }
        public DataTable GetAllBibit()
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM bibit ORDER BY id_bibit ASC";

                using (var adapter = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public void TambahBibit(
    string nama,
    string jenis,
    int harga,
    int stok,
    string deskripsi,
    string gambar,
    string status)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"INSERT INTO bibit
        (nama_bibit, jenis_bibit, harga, stok,
         deskripsi, gambar, status_stok)
        VALUES
        (@nama,@jenis,@harga,@stok,
         @desk,@gambar,@status)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@jenis", jenis);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@stok", stok);
                    cmd.Parameters.AddWithValue("@desk", deskripsi);
                    cmd.Parameters.AddWithValue("@gambar", gambar);
                    cmd.Parameters.AddWithValue("@status", status);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EditBibit(
    int id,
    string nama,
    string jenis,
    int harga,
    int stok,
    string deskripsi,
    string gambar)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"UPDATE bibit
                        SET nama_bibit=@nama,
                            jenis_bibit=@jenis,
                            harga=@harga,
                            stok=@stok,
                            deskripsi=@desk,
                            gambar=@gambar
                        WHERE id_bibit=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@jenis", jenis);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@stok", stok);
                    cmd.Parameters.AddWithValue("@desk", deskripsi);
                    cmd.Parameters.AddWithValue("@gambar", gambar);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void HapusBibit(int id)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = "DELETE FROM bibit WHERE id_bibit=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable SearchBibit(string keyword)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"SELECT * FROM bibit
                         WHERE nama_bibit ILIKE @search
                         OR jenis_bibit ILIKE @search";

                using (var adapter = new NpgsqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@search",
                        "%" + keyword + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
        }
    }
}