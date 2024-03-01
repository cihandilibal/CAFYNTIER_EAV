using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesingPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {

        //List Commands

        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds();
        List<T> GetAll();

        //Modify Commands

        void Add(T item);
        void AddRange(List<T> list);
        void Update(T item);
        void UpgrateRange(List<T> list);
        /// <summary>
        /// Bu metot veriyi pasife çeker
        /// </summary>
        /// <param name="item">Pasife cekmek istediğiniz veriyi giriniz</param>
        void Delete(T item);
        void DeleteRange(List<T> list);
        /// <summary>
        /// Bu metot veriyi siler
        /// </summary>
        /// <param name="item">Silmek istediğiniz veriyi giriniz</param>
        void Destroy(T item);
        void DestroyRange(List<T> list);

        //Linq Commands

        List<T> Where(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        List<MyModel> Select<MyModel>(Expression<Func<T, MyModel>> exp) where MyModel:class;
        T Find(int id);
        List<T> GetLastDatas(int count);
        List<T> GetFirstDatas(int count);
        List<T> GetDatas(int count);
    }
                       
}
