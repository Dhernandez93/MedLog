using MedLog.Data;
using MedLog.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedLog.Controllers
{
    public class EirController : Controller
    {
        private readonly Context context;

        public EirController(Context context)
        {
            this.context = context;
        }
        // GET: EirController/Details/5
        public EIR Consulta(string id)
        {
            var result = context.EIR.FromSqlRaw("GetData " + id).AsEnumerable().FirstOrDefault();
            return result;
        }

    }
}
