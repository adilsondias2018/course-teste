using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Entities
{
    class Comments
    {
        public string Text { get; set; }

        // contrutor genérico

        public Comments()
        {

        }

        public Comments (string text)
        {
            Text = text;
        }

    }
}
