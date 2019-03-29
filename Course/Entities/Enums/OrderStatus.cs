using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities.Enums
{
    enum OrderStatus : int // Aqui nos temos um derivação para o order status que o OrderStatus derivando do int.

    {
        /* Os valores podem ser declarados de forma aumotica onde depois de declarados recebem valores ou com 
         * os valores explicitados com no exemplo abaixo
         * 
         */


        PendingPyament = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
                       
    }
}
