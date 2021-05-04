using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using _5951071029_NguyenManhHoai_Nhom3.Models;



namespace _5951071029_NguyenManhHoai_Nhom3.Controllers
{
    [EnableCors(origins: "http://mywebclient.azurewebsites.net", headers:"*", methods:"*")]
    public class StudentController : ApiController
    {
        private SqlConnection _conn;
        private SqlDataAdapter _adapter;

        // GET api/<controller>
        public IEnumerable<Student> Get()
        {
            _conn = new SqlConnection("Data Source=DESKTOP-9OUV00A\\SQLEXPRESS;Initial Catalog=Nawab;Integrated Security=True");
            DataTable _dt = new DataTable();
            var query = "select * from student";
            _adapter = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand(query, _conn)
            };
            _adapter.Fill(_dt);
            List<Student> students = new List<Models.Student>(_dt.Rows.Count);
            if (_dt.Rows.Count > 0)
            {
                foreach (DataRow studentRecord in _dt.Rows)
                {
                    students.Add(new ReadStudent(studentRecord));
                }
            }
            return students;
        }

        // GET api/<controller>/5
        public IEnumerable<Student> Get(int id)
        {
            _conn = new SqlConnection("Data Source=DESKTOP-9OUV00A\\SQLEXPRESS;Initial Catalog=Nawab;Integrated Security=True");
            DataTable _dt = new DataTable();
            var query = "select * from student where id=" + id;
            _adapter = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand(query, _conn)
            };
            _adapter.Fill(_dt);
            List<Student> students = new List<Models.Student>(_dt.Rows.Count);
            if (_dt.Rows.Count > 0)
            {
                foreach (DataRow studentRecord in _dt.Rows)
                {
                    students.Add(new ReadStudent(studentRecord));
                }
            }
            return students;
        }

        // POST api/<controller>
        public string Post([FromBody] CreateStudent value)
        {
            _conn = new SqlConnection("Data Source=DESKTOP-9OUV00A\\SQLEXPRESS;Initial Catalog=Nawab;Integrated Security=True");
            var query = "insert into student(f_name, m_name, l_name, address, birthDay, score) values(@f_name, @m_name, @l_name, @address, @birthDay, @score)";
            SqlCommand insertConmand = new SqlCommand(query, _conn);
            insertConmand.Parameters.AddWithValue("@f_name", value.f_name);
            insertConmand.Parameters.AddWithValue("@m_name", value.m_name);
            insertConmand.Parameters.AddWithValue("@l_name", value.l_name);
            insertConmand.Parameters.AddWithValue("@address", value.address);
            insertConmand.Parameters.AddWithValue("@birthDay", value.birthDay);
            insertConmand.Parameters.AddWithValue("@score", value.score);

            _conn.Open();
            int result = insertConmand.ExecuteNonQuery();
            if (result > 0)
            {
                return "Them thanh cong";
            }
            else
            {
                return "Them that bai";
            }

        }

        // PUT api/<controller>/5
        public string Put(int id, [FromBody] CreateStudent value)
        {
            _conn = new SqlConnection("Data Source=DESKTOP-9OUV00A\\SQLEXPRESS;Initial Catalog=Nawab;Integrated Security=True");
            var query = "update student set f_name=@f_name, m_name=@m_name, l_name=@l_name, address=@address, birthDay=@birthDay, score=@score where id=" + id;
            SqlCommand insertConmand = new SqlCommand(query, _conn);
            insertConmand.Parameters.AddWithValue("@f_name", value.f_name);
            insertConmand.Parameters.AddWithValue("@m_name", value.m_name);
            insertConmand.Parameters.AddWithValue("@l_name", value.l_name);
            insertConmand.Parameters.AddWithValue("@address", value.address);
            insertConmand.Parameters.AddWithValue("@birthDay", value.birthDay);
            insertConmand.Parameters.AddWithValue("@score", value.score);

            _conn.Open();
            int result = insertConmand.ExecuteNonQuery();
            if (result > 0)
            {
                return "Update thanh cong";
            }
            else
            {
                return "Update that bai";
            }
        }

        // DELETE api/<controller>/5
        public string Delete(int id)
        {
            _conn = new SqlConnection("Data Source=DESKTOP-9OUV00A\\SQLEXPRESS;Initial Catalog=Nawab;Integrated Security=True");
            var query = "delete from student where id=" + id;
            SqlCommand insertConmand = new SqlCommand(query, _conn);

            _conn.Open();
            int result = insertConmand.ExecuteNonQuery();
            if (result > 0)
            {
                return "Xoa thanh cong";
            }
            else
            {
                return "Xoa that bai";
            }
        }
    }
}