using System;

namespace Course2.Entities

{
    public class Comments
    {
        public string Text { get; set; }

        public Comments()
        {

            //Construtor padrão

        }

        public Comments(string text)
        {
            Text = text;

        }
    }
}
