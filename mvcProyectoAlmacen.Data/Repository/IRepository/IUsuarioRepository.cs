﻿using mvcProyectoAlmacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoAlmacen.Data.Repository.IRepository
{
    public interface IUsuarioRepository: IRepository<ApplicationUser>
    {
        void BloquearUsuario(string IdUsuario);
        void DesbloquearUsuario(string IdUsuario);
    }
}
