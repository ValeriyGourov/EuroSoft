using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Data.Entities;

namespace Data
{
    /// <summary>
    /// Общий класс репозитория для работы с базой данных. Содержит общие возможности для всех типов данных.
    /// </summary>
    /// <typeparam name="T">Основной класс модели, проецируемый в базу данных.</typeparam>
    internal class GenericRepository<T> where T : EntityBase
    {
        /// <summary>
        /// Экземпляр контекста.
        /// </summary>
        protected readonly ApplicationDbContext _db;

        /// <summary>
        /// Коллекция всех элементов сущности основного класса модели.
        /// </summary>
        protected readonly DbSet<T> _set;

        /// <summary>
        /// Основной конструктор, использующий контекст базы данных.
        /// </summary>
        /// <param name="db">Контекст базы данных.</param>
        public GenericRepository(ApplicationDbContext db)
        {
            _db = db;
            _set = _db.Set<T>();
        }

        /// <summary>
        /// Возвращает элемент сущности с указанными значениями первичного ключа.
        /// </summary>
        /// <param name="keyValues">Значения первичного ключа для искомой сущности.</param>
        /// <returns>Найденный элемент сущности.</returns>
        public T Get(params object[] keyValues) => _set.Find(keyValues);

        /// <summary>
        /// Возвращает идентификаторы всех элементов.
        /// </summary>
        /// <returns>Коллекция идентификаторов всех элементов.</returns>
        public IEnumerable<int> GetAllIds() => _set.AsNoTracking().Select(item => item.Id).ToList();

        /// <summary>
        /// Создаёт новую сущность в базе данных. Для принятия изменений необходимо вызвать метод SaveChanges.
        /// </summary>
        /// <param name="entity">Данные создаваемой сущности.</param>
        public void Create(T entity) => _set.Add(entity);

        /// <summary>
        /// Сохраняет все изменения в базе данных, произведённые в контексте.
        /// </summary>
        public void SaveChanges() => _db.SaveChanges();
    }
}
