using Starkov.Models;

namespace Starkov.Controllers
{
    public class DbController
    {
        static public void AddContract(Contract contract)
        {
            using (var db = new DataBaseContext())
            {
                db.Contracts.Add(contract);
                db.SaveChanges();
                MessageBox.Show("Контракт успешно создан");
            }
        }
        static public void DeleteContract(int id)
        {
            using (var db = new DataBaseContext())
            {
                var contract = db.Contracts.FirstOrDefault(el => el.Id == id);
                db.Contracts.Remove(contract);
                db.SaveChanges();
                MessageBox.Show("Удаление прошло успешно");
            }
        }
        static public void AddEmployee(Employee employee)
        {
            using (var db = new DataBaseContext())
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                MessageBox.Show("Сотрудник успешно добавлен");
            }
        }
        static public void DeleteEmployee(int id)
        {
            using (var db = new DataBaseContext())
            {
                var employee = db.Employees.FirstOrDefault(el => el.Id == id);
                var contract = db.Contracts.FirstOrDefault()
                db.Employees.Remove(employee);
                db.SaveChanges();
                MessageBox.Show("Удаление прошло успешно");
            }
        }
        static public void AddHouse(House house)
        {
            using (var db = new DataBaseContext())
            {
                db.Houses.Add(house);
                db.SaveChanges();
                MessageBox.Show("Квартира/Дом добавлен успешно");
            }
        }
        static public void DeleteHouse(int id)
        {
            using (var db = new DataBaseContext())
            {
                var house = db.Houses.FirstOrDefault(el => el.Id == id);
                db.Houses.Remove(house);
                db.SaveChanges();
                MessageBox.Show("Удаление прошло успешно");
            }
        }
        static public void AddUser(User user)
        {
            using(var db = new DataBaseContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Клиент добавлен успешно");
            }
        }
        static public void DeleteUser(int id)
        {
            using(var db = new DataBaseContext())
            {
                var user = db.Users.FirstOrDefault(el => el.Id ==id);
                db.Users.Remove(user);
                db.SaveChanges();
                MessageBox.Show("Удаление прошло успешно");
            }
        }
    }
}
