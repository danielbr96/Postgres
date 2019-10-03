using System;
using System.Collections.Generic;

namespace Tareabd.ModelsSQL
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }
    }
}
