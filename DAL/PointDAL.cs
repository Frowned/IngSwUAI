using BE.DTO;
using BE.Entities;
using DAL.Helper;
using Infrastructure.Interfaces.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PointDAL : IPointDAL
    {
        private readonly DatabaseHelper dbHelper;

        public PointDAL()
        {
            dbHelper = new DatabaseHelper();
        }


    }
}
