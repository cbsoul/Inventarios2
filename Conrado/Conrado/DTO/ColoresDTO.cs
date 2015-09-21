using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conrado.DTO
{

    class ColoresDTO
    {
        private int IdColor;
        private String Color;

        public int idColor
        {
            get { return IdColor; }
            set { IdColor = value; }
        }

        public String color
        {
            get { return Color; }
            set { Color = value;}
        }

    }
}
