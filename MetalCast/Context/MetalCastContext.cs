using MetalCast.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MetalCast.Context
{
    public class MetalCastContext: DbContext
    {
        //public object Usuario { get; internal set; }
        public DbSet<Usuario> Usuario { set; get; }
        // CuentaUsuario
    }
}