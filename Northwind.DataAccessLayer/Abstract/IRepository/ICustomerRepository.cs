using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.EntityLayer.Concrete.Models;

namespace Northwind.DataAccessLayer.Abstract.IRepository
{
    public interface ICustomerRepository
    {
        //TODO : örnek olması için deneme amaçlı metod.
        //TODO : bu sınıfa generic repositoryden kalıtım vermemiz gerekmez miydi? Hayır gerekmez burası nesnesin özel şablonunu tutar generic verirsek aynı şablonları tekrarlamış oluruz.
        IQueryable CustomerReport();

        Customer GetByStringId(string id);
    }
}
