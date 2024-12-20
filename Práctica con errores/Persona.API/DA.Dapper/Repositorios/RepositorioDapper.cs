﻿using Abstracciones.DA;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Dapper.Repositorios
{
    public class RepositorioDapper : IRepositorioDapper
    {
        private readonly IConfiguration _configuration;

        public RepositorioDapper(IConfiguration configuration)
        {
            _configuration = configuration;
            _conexionBaseDatos = new SqlConnection(_configuration.GetConnectionString("PracticaSem1"));
        }

        public SqlConnection _conexionBaseDatos { get; }
        public SqlConnection ObtenerRepositorioDapper()
        {
            return _conexionBaseDatos;
        }
    }
}
