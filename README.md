# Тестовое задание #

Необходимо создать пример отображения списка оборудования из базы данных. Неотъемлемой частью задания является дизайн UI (расположение элементов управления на форме).

Решение должно включать в себя скрипт, создающий базу данных и таблицы, а также минимальный набор тестовых данных.

### Структура базы данных  ###
В базе данных должны быть следующие таблицы и поля: 
Оборудование

* Артикул оборудования (строка от 6 до 18 символов)
* Описание оборудования (строка 100 символов)
* Цена (double, 2 знака после запятой). Диапазон значений от 0 до 15000.
* Индикатор “На складе” (Boolean).

Примечания (связь с таблицей Оборудование один ко многим по артикулу)

* Артикул оборудования (строка от 6 до 18 символов)
* Примечание (строка 500 символов)

Ссылки (связь с таблицей Оборудование один ко многим по артикулу)

* Артикул оборудования (строка от 6 до 18 символов)
* URL
* Название

### Интерфейс ###
Готовое решение должно состоять из одного экрана - экран отображения списка оборудования из базы данных. Отображение должно происходить по нажатию на кнопку Display с использованием AJAX.

### Технологии ###
Необходимо использовать следующие технологии и языки программирования: ASP.NET MVC, C#, MS SQL, HTML, JavaScript, AJAX. JSON – плюс.