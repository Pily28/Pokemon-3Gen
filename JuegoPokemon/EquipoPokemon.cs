using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPokemon
{

    public  class EquipoPokemon
    {
        public string NombreJugador { get; set; }
        public List<string> PokemonSeleccionados { get; set; }

        public EquipoPokemon(string nombreJugador)
        {
            NombreJugador = nombreJugador;
            PokemonSeleccionados = new List<string>();
        }

        public bool LimiteAlcanzado()
        {
            return PokemonSeleccionados.Count >= 6;
        }
    }
}
