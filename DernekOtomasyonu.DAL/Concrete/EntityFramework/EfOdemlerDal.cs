using DernekOtomasyonu.DAL.Abstract;
using DernekOtomasyonu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;

namespace DernekOtomasyonu.DAL.Concrete.EntityFramework
{
    public class EfOdemelerDal : IOdemelerDal
    {
        private string _connectionString;

        public EfOdemelerDal()
        {
            _connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory().ToString() + "/DernekOtoDB1.accdb";
        }

        public void Add(Odemeler odemler)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Odemelers (AidatID, UyeTC, Durum) VALUES (?, ?, ?)";

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("?", odemler.AidatID);
                    command.Parameters.AddWithValue("?", odemler.UyeTC);
                    command.Parameters.AddWithValue("?", odemler.Durum);

                    command.ExecuteNonQuery();
                }
            }
        }

       

        public void Delete(Odemeler odemler)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM Odemelers WHERE OdemeID = ?";

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("?", odemler.OdemeID);

                    command.ExecuteNonQuery();
                }
            }
        }
        public List<Odemeler> GetOdemelerByDurum(bool durum)
        {
            List<Odemeler> odemeler = new List<Odemeler>();

           
            string query = "SELECT * FROM Odemelers WHERE Durum = @Durum";

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Durum", durum);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Odemeler odeme = new Odemeler
                            {
                                OdemeID = Convert.ToInt32(reader["OdemeID"]),
                                AidatID = Convert.ToInt32(reader["AidatID"]),
                                UyeTC = reader["UyeTC"].ToString(),
                                Durum = Convert.ToBoolean(reader["Durum"])
                            };
                            odemeler.Add(odeme);
                        }
                    }
                }
            }

            return odemeler;
        }

     

        public List<Odemeler> GetOdemelerByUyeTCDurum(string uyeTC, bool durum)
        {
            //ÜYE İÇİN KİŞİSEL OLARAK ÖDEDİMİ ÖDEMEDİMİ İŞLEMLERİNE BAKACAK METHOD
            List<Odemeler> odemeler = new List<Odemeler>();

           
            string query = "SELECT * FROM Odemelers WHERE UyeTC = @UyeTC AND Durum = @Durum";

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UyeTC", uyeTC);
                    command.Parameters.AddWithValue("@Durum", durum);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Odemeler odeme = new Odemeler
                            {
                                OdemeID = Convert.ToInt32(reader["OdemeID"]),
                                AidatID = Convert.ToInt32(reader["AidatID"]),
                                UyeTC = reader["UyeTC"].ToString(),
                                Durum = Convert.ToBoolean(reader["Durum"])
                            };
                            odemeler.Add(odeme);
                        }
                    }
                }
            }

            return odemeler;
        }

        public List<Odemeler> GetByUyeTC(string uyeTC)
        {
            List<Odemeler> result = new List<Odemeler>();

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Odemelers WHERE UyeTC = ?";

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("?", uyeTC);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Odemeler odeme = new Odemeler
                            {
                                OdemeID = Convert.ToInt32(reader["OdemeID"]),
                                AidatID = Convert.ToInt32(reader["AidatID"]),
                                UyeTC = reader["UyeTC"].ToString(),
                                Durum = Convert.ToBoolean(reader["Durum"])
                              
                            };
                           
                            result.Add(odeme);
                        }
                    }
                }
            }

            return result;
        }

        public List<Odemeler> GetAll()
        {
            List<Odemeler> result = new List<Odemeler>();

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Odemelers";

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Odemeler odeme = new Odemeler
                            {
                                OdemeID = Convert.ToInt32(reader["OdemeID"]),
                                AidatID = Convert.ToInt32(reader["AidatID"]),
                                UyeTC = reader["UyeTC"].ToString(),
                                Durum = Convert.ToBoolean(reader["Durum"])
                                
                            };
                          
                            result.Add(odeme);
                        }
                    }
                }
            }

            return result;
        }

        public Odemeler GetById(int OdemelerID)
        {
            Odemeler result = null;

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Odemelers WHERE OdemeID = ?";

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("?", OdemelerID);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new Odemeler
                            {
                                OdemeID = Convert.ToInt32(reader["OdemeID"]),
                                AidatID = Convert.ToInt32(reader["AidatID"]),
                                UyeTC = reader["UyeTC"].ToString(),
                                Durum = Convert.ToBoolean(reader["Durum"])
                            };
                        }
                    }
                }
            }

            return result;
        }

        public void Update(Odemeler odemler)
        {
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

             
       
                // Sonra diğer alanları güncelle
                string updateSql = "UPDATE Odemelers SET AidatID = ?, UyeTC = ?, Durum = ? WHERE OdemeID = ?";

                using (OleDbCommand updateCommand = new OleDbCommand(updateSql, connection))
                {
                    updateCommand.Parameters.AddWithValue("?", odemler.AidatID);
                    updateCommand.Parameters.AddWithValue("?", odemler.UyeTC);
                    updateCommand.Parameters.AddWithValue("?", odemler.Durum);
                    updateCommand.Parameters.AddWithValue("?", odemler.OdemeID);

                    updateCommand.ExecuteNonQuery();
                }
            }
        }


        // OdemelerDAL sınıfında
        public Odemeler GetOdemelerByUyeTCAndAidatID(string uyeTC, int aidatID)
        {
            Odemeler odeme = null;

            
            string query = "SELECT * FROM Odemelers WHERE UyeTC = @UyeTC AND AidatID = @AidatID";

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UyeTC", uyeTC);
                    command.Parameters.AddWithValue("@AidatID", aidatID);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            odeme = new Odemeler
                            {
                                OdemeID = Convert.ToInt32(reader["OdemeID"]),
                                AidatID = Convert.ToInt32(reader["AidatID"]),
                                UyeTC = reader["UyeTC"].ToString(),
                                Durum = Convert.ToBoolean(reader["Durum"])
                            };
                           
                        }
                    }
                }
            }

            return odeme;
        }
        public List<string> GetUnpaidMembersTC()
        {
            List<string> tcList = new List<string>();

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand("SELECT UyeTC FROM Odemelers WHERE Durum = False", connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tcList.Add(reader["UyeTC"].ToString());
                        }
                    }
                }
            }

            return tcList;
        }
    


    }
}
