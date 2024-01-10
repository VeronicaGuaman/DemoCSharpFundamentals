using System.Linq.Expressions;

namespace DemoCSharpFundamentals
{
    public class DelegadoReal 
    {
        //public virtual T FirstOrDefaultSync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        //{
        //    IQueryable<T> dbQuery = _context.Set<T>();
        //    foreach (Expression<Func<T, object>> navigation in navigationProperties)
        //    {
        //        dbQuery = dbQuery.Include(navigation);
        //    }
        //    T result = dbQuery.FirstOrDefault(where);
        //    return result;
        //}
    }

    public class LLamadoDelegado
    {
        //public UserRoleEntity GetById(int id)
        //{
        //    Expression<Func<UserRoleEntity, object>> navigationPropertiesUser = x => x.User;
        //    Expression<Func<UserRoleEntity, object>> navigationPropertiesRol = x => x.Role;
        //    Expression<Func<UserRoleEntity, object>>[] navigationProperties = { navigationPropertiesUser, navigationPropertiesRol };

        //    UserRoleEntity result = this.FirstOrDefaultSync(x => x.Id == id, navigationProperties);
        //    return result;
        //}
    }
}
