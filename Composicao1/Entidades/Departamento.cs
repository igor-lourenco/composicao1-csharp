using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao1.Entidades {
    class Departamento {

        public string Nome { get; set; }

        public Departamento() {

        }

        public Departamento (string nome) {
            Nome = nome;
        }
    }
}
