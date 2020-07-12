using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._1_SingleResponsibility
{
    class Bad_
    {
        public void QuoteOrder() { }

        public void RecordOrder() { }

        public void BillOrder() { }
    }
}
