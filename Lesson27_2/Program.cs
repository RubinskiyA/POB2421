using Lesson27_2;

// Создание нового банковского счета с начальным балансом 1000
BankAccount account = new BankAccount(1000m);

// Отображение информации о счете
account.DisplayAccountInfo();

// Пополнение счета
account.Deposit(250m);

// Снятие денег со счета
account.Withdraw(100m);

// Попытка снятия денег сверх доступного баланса
account.Withdraw(2000m);

// Отображение информации о счете после операций
account.DisplayAccountInfo();