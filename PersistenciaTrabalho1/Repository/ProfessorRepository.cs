﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaTrabalho1.Models;

namespace PersistenciaTrabalho1.Repository
{
    public class ProfessorRepository
    {
        private PersistenciaTrabalho1Context db = new PersistenciaTrabalho1Context();
        public IEnumerable<Professor> ListarProfessores()
        {
            return db.Professores.ToList();
        }
    }
}
