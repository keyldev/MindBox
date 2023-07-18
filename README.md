## Задание:

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

* Юнит-тесты

* Легкость добавления других фигур

* Вычисление площади фигуры без знания типа фигуры в compile-time

* Проверку на то, является ли треугольник прямоугольным

### Решение задания:

Библиотека с абстрактным классом Shape и примерами Circle, Triangle: [ссылка](https://github.com/keyldev/MindBox/tree/master/MindBox.Library)

Юнит-тесты классов Triangle и Circle: [ссылка](https://github.com/keyldev/MindBox/tree/master/MindBox.Task.Tests)

RunTime с compile-time фигурой: [ссылка](https://github.com/keyldev/MindBox/tree/master/MindBox.Task.Tests)

## Задание 2:
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

```sql
SELECT p.Name as 'Имя', c.Name as 'Категория' FROM Products p 
LEFT JOIN ProductCategories PC ON p.Id = PC.product_id 
LEFT JOIN Categories c ON c.Id = PC.category_id
ORDER BY p.Name
```