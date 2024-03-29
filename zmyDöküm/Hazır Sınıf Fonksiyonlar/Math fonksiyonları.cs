﻿
#region ABS : Her türlü değerin mutlak değeri veren fonksiyondur
Console.WriteLine(Math.Abs(10));
Console.WriteLine(Math.Abs(-10));
#endregion

#region Ceiling : Yuvarlama işlemini gerçekleştirir fakat her daim yukarıya yuvarlar Floor Tam tersi işlemi gerçeleştirir her daim altına yuvarlar
Console.WriteLine(Math.Ceiling(3.14f)); //4' yuvarlama işlemini gerçekleştirecektir
Console.WriteLine(Math.Floor(3.82)); //3 e yuvarlayacaktır
#endregion

#region Round : Yuvarlama işlemi fakat bu işlemi en yakın değere göre yapmaktadır.
Console.WriteLine(Math.Round(3.14));//3
Console.WriteLine(Math.Round(3.82));//4
#endregion

#region Pow : Sayının üst'ünü almaya yarayan fonksiyondur.
Console.WriteLine(Math.Pow(3, 3));//27
#endregion

#region Sqrt : Sayının karakökünü almamıza yarayan fonksiyondur.
Console.WriteLine(Math.Sqrt(16));//4
#endregion

#region Truncate : Ondalıklı sayıda yukarı aşağı yuvarlama yapmadan küsüratı atan fokniyondur.
Console.WriteLine(Math.Truncate(3.14));
#endregion

#region //Sign: Verilen değerin negatif veya pozitiflik durumunu elde etmemizi sağlar. Eğer değer 0 veya pozitif değer ise 1, negatif ise -1 döndürür.
Console.WriteLine(Math.Sign(150));//+1
Console.WriteLine(Math.Sign(-150));//-1
#endregion

#region Clamp: Verilen değerin, belirtilen minimum ve maksimum değerlerini aşmadığından emin olmamızı sağlar.
float horizontalAxis = Input.GetAxis("Horizontal");
Vector3 newPosition = transform.position + new Vector3(horizontalAxis * _speed * Time.deltaTime, 0, 0);
newPosition.x = Mathf.Clamp(newPosition.x, -_limitHorizontal, _limitHorizontal);
#endregion

