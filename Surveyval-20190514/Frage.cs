using System;

namespace Surveyval_20190514
{
    [Serializable]
    class Frage
    {
        public String strFragetext { get; set; }
        public int nAntwortart { get; set; }

        public Frage()
        {
            strFragetext = "";
            nAntwortart = 0;
        }

        public Frage(String fragetext, int antwortart)
        {
            strFragetext = fragetext;
            nAntwortart = antwortart;
        }
    }
}
