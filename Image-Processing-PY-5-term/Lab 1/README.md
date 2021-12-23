# Лабораторная работа №1

Работу выполнили **Оганян Роберт**, **Тронин Дмитрий**, **Рухович Игорь**, студенты группы **381808-1**.

### Структура проекта
* Папки **task1**, **task2**, **task31**, **task32** отвечают за соответствующие задания.
* В папке **utils** находится функция **measure_time**, возвращающая результаты выполнения переданной в нее функции и среднее время работы выполнения этой функции.

### Задание 1: Метрика сходства двух изображений

В данной работе мы реализовали **immse**, **psnr**, **ssim**.

* Immse: Область значений [0; 65025]. Чем меньше результат, тем  изображения более схожи.
* psnr: Область значений [0; 100]. Чем больше результат, тем изображения более схожи.
* ssim: Область значений [0; 1]. Чем больше результат, тем изображения более схожи.

##### Сравнение одинаковых изображений:

* IMMSE одинаковых  0.0
* PSNR одинаковых 100.0
* SSIM одинаковых 1.0

##### Сравнение rgb изображения с "шумной версией" (random_noise)

* IMMSE цветного 17369.34445100647
* IMMSE серого 14326.246243132913
* PSNR цветного 5.732969331337074
* PSNR серого: 6.569479492180873
* SSIM цветных: 
	+ Мой SSIM: 0.0000682395
	+ structural_similarity: 0.010716991346757528

#### Сравнение монохромного  изображения с "шумной версией" (random_noise)

* Мой SSIM: 0.0000786222
* structural_similarity: 0.005088726353130398

Реализованный нами ssim отличается от питоновского structural_similarity. Возможно это из-за того, что мы не учитывали коэффициент "Структура".

### Задание 2:

Реализована конвертация по формуле **average (R + G + B) / 3**, за которую отвечает функция **monochrome**. 

Также понадобилась функция **transform** для сравнения изображения после моей конвертации и изображения после питоновской функции. **transform** приводит изображения к одинаковой размерности.


* Среднее время работы моей конвертации в монохромное за 10 запусков: 0.04887722857142856

* Среднее ремя работы встроенной конвертации в монохромное за 10 запусков:  0.005994319915771484

Как видим, встроенная функция работает быстрее.

Также сравним схожесть полученных двух изображений:

* IMMSE: 0.0
* PSNR: 100.0
* SSIM: 1.0

### Задание 3.1: Конвертация между цветовыми моделями

В данной работе мы реализовали конвертацию между из RGB в HSV.

Для корректного сравнения результатов нашей реализации и реализации библиотеки OpenCV значения были отнормированы:
+ H [0, 179]
+ V [0, 255]
+ S [0, 255]

**Метрика PSNR:** 54.579

Такое разлчичие объсняется округлением:

Посчитаем наибольшую разницу в значениях - она равна 2. Значит ошибка произошла из-за нормировки и маленьких величин.

**Время работы нашей реализации:** 0.59599 секунды

**Время работы библиотечной реализации:** 0.00018 секунды

Такое различие можно объяснить устройством библиотеки (OpenCv написан на языке C++, который намного быстрее Python).

### Задание 3.2: Конвертация между цветовыми моделями.

#### Реализовать фильтр “увеличение яркости” пикселя для RGB представления, для другой модели.

В программе выводятся
 - Оригинальное изображение
 - Изображение с увеличением яркости всех точек в 1.5 раза
 - Изображение с уменьшением яркости всех точек в 1.5 раза

 Далее происходит трансформация исходного RGB (BGR) изображения в HSV и те же операции выполняются для нового изображения

 После этого происходит сравнение точек в исходном изображении с аналогичным в HSV (точки переводятся в BGR для проведения сравнения).
 Используется метрика `Structural Similarity Index Metric`.

**Времена работы всех функций в работе измерены и усреднены с отсечкой выбросов (по 20% минимальных и максимальных результатов)**