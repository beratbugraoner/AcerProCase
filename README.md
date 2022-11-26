# AcerProCase
 
 .Net Core 6 Web API Projesidir.
 
 Proje ile ilgili soru sormak veya herhangi bir konuda iletişime geçmek için 
 
 No: 05545734462
 
 Mail: onerberat0@gmail.com

## Kısa Özet

Proje'de jwt ile token bazlı authentication islemleri gerceklestirilmistir. Loglama için ILogger Kullanılmıştır.Katmanlı mimari,solid prensipleri,DI vs gibi 
prensiplere uygun bir kod yazılmıştır. Projeyi vize haftamdan dolayı yetiştirmek için normalden daha acele bir şekilde yazma 
zorunluluğum doğmuştur. Bu bir mazaret değildir,projeyi gerçekleştirebildiğim kadar test edip buglarını minimalize etmeye çalıştım.
Eğer kullanıcı gözümden  kaçan buglar ile karşılaştıysa yukarıdaki iletişim bilgilerinden iletişime geçildiği takdirde çok kısa bir sürede
bunları düzeltebilirim. 

## Migrations
- dotnet ef --startup-project ../WebAPI/  migrations add InitialCreate
- dotnet ef --startup-project ../WebAPI/ database update


## Endpointler

![image](https://user-images.githubusercontent.com/62885525/203973093-b8694478-8b05-4bc7-b39b-8e22c52bdf92.png)

## Register

Jwt bazlı register islemimiz.

![image](https://user-images.githubusercontent.com/62885525/203974081-51349fbf-861a-49c2-8e04-606be4872466.png)

Dönen token

![image](https://user-images.githubusercontent.com/62885525/203974226-754dae8c-5f1a-4d48-b4b2-65c3fa6dbddd.png)

## Login

![image](https://user-images.githubusercontent.com/62885525/203974375-e98520de-7157-4c97-aa1b-579ed71b22b4.png)

Login işlemi sonrası dönen response

![image](https://user-images.githubusercontent.com/62885525/203974445-9f0b8fdc-9e6b-4b3c-89e6-68ad6fdb0e08.png)


## Hatalı Auth İslemleri

Hatalı veya yanlış islemler sonrası gerceklesen response örneği, diger senaryolar kalabalık olmasın diye koyulmadı.

![image](https://user-images.githubusercontent.com/62885525/203974607-8301d156-d47c-4230-a031-0144b3cb946c.png)


## Örnek Add Endpointi

 Ornek olarak verdigimiz data body'miz
 
![image](https://user-images.githubusercontent.com/62885525/203973257-9f693ff9-32ae-45e1-88cd-263d492009c5.png)

 Response:
 
![image](https://user-images.githubusercontent.com/62885525/203973432-265508c3-a7df-47d5-911c-ca80af5cbdae.png)

## Statusu True Olan (Yayında olan haberler)

Bir haberin yayında olması icin statusu true olması lazımdır.

![image](https://user-images.githubusercontent.com/62885525/203973662-48c4a629-821a-4436-a415-f982df76b2fb.png)

## Statusu Degistirme

Bu endpointler 1 adet endpointe düsürülüp de yapılabilir. Tercih sebebi 2 farklı method yazdım.

![image](https://user-images.githubusercontent.com/62885525/203973825-edc1f476-a07c-4c3a-a462-6ac109afa9a7.png)


Proje ile ilgili soru sormak veya herhangi bir konuda iletişime geçmek için 
No: 05545734462
Mail: onerberat0@gmail.com
