# Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

# Описание решения
1. Пользователь вводит размер первоначального массива.
2. Создан метод CreateInputArray, с помощью которого пользователь формирует с клавиатуры первоначальный массив, состоящий из строк различной длины.
3. Создан метод ModifyArray, с помощью которого формируется массив из строк, длина которых меньше, либо равна 3. Краткое описание метода:
    - На вход метода подается исходный массив;
    - В первом цикле метода определяется количество элементов, длина которых <= 3. После этого формируется пустой массив размером равным количеству элементов, длина которых <= 3;
    - Во втором цикле метода проводится проверка, если длина элемента исходного массива <= 3, то в этом случае данный элемент добавляется во второй массив;
    - Блок-схему алгоритма можно найти в папке Block diagram/
4. Создан метод PrintArray для вывода первоначального и выходного массивов с требуемым форматом.