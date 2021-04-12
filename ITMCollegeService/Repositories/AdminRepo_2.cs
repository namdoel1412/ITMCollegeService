using ITMCollegeService.DTO;
using ITMCollegeService.Extensions;
using ITMCollegeService.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.Repositories
{
    public interface IAdminRepo_2
    {
        public Task<bool> CreateAdminAsync(ModifyAdminDTO body);
        public Task<bool> UpdateAdmin(int id, ModifyAdminDTO body);
        public Task<bool> DeleteAdminAsync(int id);
        public Task<IList<GetAdminDTO>> GetAllAdmins();
        public Task<GetAdminDTO> GetAdminById(int id);

    }
    public class AdminRepo_2
    {
        //public async Task<bool> CreateAdminAsync(ModifyAdminDTO body)
        //{
        //    string sql = $"Insert Into {ADMINTABLE} (name, email, address, phone, gender_id, created_at, updated_at)" +
        //        $" values (@name, @email, @address, @phone, @gender_id, @created_at, @updated_at)";
        //    try
        //    {
        //        using (MySqlConnection conn = await DBHelper.SetConnection())
        //        {
        //            MySqlCommand cmd = new MySqlCommand();
        //            cmd.Connection = conn;
        //            cmd.CommandText = sql;
        //            cmd.CommandTimeout = 20000;
        //            cmd.Parameters.Add(new MySqlParameter("name", body.Name));
        //            cmd.Parameters.Add(new MySqlParameter("email", body.Email));
        //            cmd.Parameters.Add(new MySqlParameter("address", body.Address));
        //            cmd.Parameters.Add(new MySqlParameter("phone", body.Phone));
        //            cmd.Parameters.Add(new MySqlParameter("gender_id", body.Gender_id));
        //            cmd.Parameters.Add(new MySqlParameter("created_at", !String.IsNullOrWhiteSpace(body.Created_at.ToString()) ? body.Created_at.ToString("yyyy-MM-dd HH:mm") : DateTime.Now.ToString("yyyy-MM-dd HH:mm")));
        //            cmd.Parameters.Add(new MySqlParameter("updated_at", !String.IsNullOrWhiteSpace(body.Created_at.ToString()) ? body.Created_at.ToString("yyyy-MM-dd HH:mm") : DateTime.Now.ToString("yyyy-MM-dd HH:mm")));
        //            if (await cmd.ExecuteNonQueryAsync() > 0)
        //            {
        //                return true;
        //            }
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // LOG
        //        bool tmp;
        //        tmp = true;
        //    }
        //    return false;
        //}

        //public async Task<bool> DeleteAdminAsync(int id)
        //{
        //    string sql = $"Delete From {ADMINTABLE} where id = @id";
        //    try
        //    {
        //        using (MySqlConnection conn = await DBHelper.SetConnection())
        //        {
        //            MySqlCommand cmd = new MySqlCommand();
        //            cmd.Connection = conn;
        //            cmd.CommandText = sql;
        //            cmd.CommandTimeout = 20000;
        //            if (await cmd.ExecuteNonQueryAsync() > 0)
        //            {
        //                return true;
        //            }
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // LOG
        //        bool tmp;
        //        tmp = true;
        //    }
        //    return false;
        //}

        //public async Task<GetAdminDTO> GetAdminById(int id)
        //{
        //    string sql = "select * from " + ADMINTABLE + " where id=@id";
        //    GetAdminDTO data = new GetAdminDTO();
        //    try
        //    {
        //        using (MySqlConnection conn = await DBHelper.SetConnection())
        //        {
        //            MySqlCommand cmd = new MySqlCommand();
        //            cmd.Connection = conn;
        //            cmd.CommandText = sql;
        //            cmd.CommandTimeout = 20000;
        //            cmd.Parameters.Add(new MySqlParameter("id", id));
        //            using (DbDataReader reader = await cmd.ExecuteReaderAsync())
        //            {
        //                if (reader.HasRows)
        //                {
        //                    while (await reader.ReadAsync())
        //                    {
        //                        data.Id = reader.GetInt32(0);
        //                        data.Name = reader.GetValue(1).ToString();
        //                        data.Email = reader.GetValue(2).ToString();
        //                        data.Address = reader.GetValue(3).ToString();
        //                        data.Phone = reader.GetValue(4).ToString();
        //                        data.Gender_id = reader.GetInt32(5);
        //                        data.Created_at = reader.GetValue(6).ToString();
        //                        data.Updated_at = reader.GetValue(4).ToString();
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // LOG
        //        bool tmp;
        //        tmp = false;
        //    }
        //    return data;
        //}

        //private const string ADMINTABLE = "admin";
        
        //public async Task<IList<GetAdminDTO>> GetAllAdmins()
        //{
        //    string sql = "select * from " + ADMINTABLE;
        //    IList<GetAdminDTO> lstData = new List<GetAdminDTO>();
        //    try
        //    {
        //        using (MySqlConnection conn = await DBHelper.SetConnection())
        //        {
        //            MySqlCommand cmd = new MySqlCommand();
        //            cmd.Connection = conn;
        //            cmd.CommandText = sql;
        //            cmd.CommandTimeout = 20000;
        //            using (DbDataReader reader = await cmd.ExecuteReaderAsync())
        //            {
        //                if (reader.HasRows)
        //                {
        //                    while (await reader.ReadAsync())
        //                    {
        //                        lstData.Add(new GetAdminDTO
        //                        {
        //                            Id = reader.GetInt32(0),
        //                            Name = reader.GetValue(1).ToString(),
        //                            Email = reader.GetValue(2).ToString(),
        //                            Address = reader.GetValue(3).ToString(),
        //                            Phone = reader.GetValue(4).ToString(),
        //                            Gender_id = reader.GetInt32(5),
        //                            Created_at = reader.GetValue(6).ToString(),
        //                            Updated_at = reader.GetValue(4).ToString(),
        //                        });
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // LOG
        //        bool tmp;
        //        tmp = false;
        //    }
        //    return lstData;
        //}

        //public async Task<bool> UpdateAdmin(int id, ModifyAdminDTO body)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
