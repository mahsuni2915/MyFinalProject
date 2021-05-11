using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //GEneric Constraint  T:class REferans tip olabilir demek ",IENtity " demek sadece Ienttiy olanları al demek
    //new lene bilir olmalı yani entity katmanındaki concretteki classlar olanilir interfaceler olmaz 
    public interface IEntitiyRepository<T> where T:class ,IEntity,new()
    {


        List<T> GetAll(Expression<Func<T, bool>> filter = null);// filitre koymaya yarar 
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}
