# Задание 1.

## Библиотека геометрических фигур.

## Общие сведения.
Библиотека написана на C# 7.0, юнит тесты на xUnit.


Реализован публичный контракт IShape, который описывает поведение каждой фигуры, которую мы захотим реализовать.

Каждая фигура должна будет иметь метод вычисления площади, но как она будет это делать - не так важно.

Далее созданы классы круга и треугольника, которые вычисляют площадь по радиусу и трем торонам соответственно.

Также при инициализации есть проверки на некоректные.
Для окружности:
- Радиус должен быть положительным;

Для треугольника:
- Стороны должны быть строго положительными;
- Стороны должны удовлетворять равенству треугольника (a + b > c);

Было решено работать нее по TDD, поэтому тесты писались в конце.
В тестах учтены все крайние случаи. Покрытие по Coverages в Rider = 100%.

Для удобства просмотра был сделан проект MainApplication, где описаны стандартные сценарии использования.

# Задание 2.

В базе данных создано 3 таблицы:
- Категории;
- Продукты;
- Таблица связи продуктов и категорий (многие ко многим)

Создан запрос для получения всех пар продукт ‒ категория из таблицы связи, даже если у него нет категории.
Скрипт приложен в файле [sript.sql](./script.sql).