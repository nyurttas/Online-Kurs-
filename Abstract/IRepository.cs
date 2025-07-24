using _9_EFOnlineCourseDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EFOnlineCourseDB.Abstract
{
    //Butun Repository sınıflarımızın içerisinde uygulanması gereken metodları buraya koyuyoruz. Bu sayede herhangi bir entity için repository oluştururken hangi metodları uygulamamız gerektiğini bileceğiz.

    /*
    Generic yapı, C# dilinde farklı veri türleriyle çalışabilen esnek 
    ve yeniden kullanılabilir kodlar yazmamızı sağlayan bir yapıdır.

    Tip bağımsızdır. (Herhangi bir veri tipi ile çalışabilir.)
    Kod tekrarını önler.
    Performans sağlar. (Tip dönüşümleri olmadığı için daha hızlıdır.)
     */

    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void Update();
        void DeleteByID(Guid id);
        List<T>? GetAll();
        T? GetByID(Guid id);
    }
}
