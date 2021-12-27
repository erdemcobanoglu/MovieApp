## Ne Kullandım ?

- C#
- .Net Core Api
- EntityFramework Core
- Code First
- Repository Pattern
- Dependency Injection
- Newtonsoft Json 
- Fluentvalidation 
- Autofac
- Git-Github
- MsSql

## Verileri Kaydetme

- Json dosyası içerisindeki verileri veritabanına kaydetmek için uygun bir model oluşturup.
- EntityFramework yardımıile MsSql ile mapping yapıldı.

## Repository,

- Veritabanına kayıt attıktan sonra sıra bu kayıtlar ve veritabanı üzerinden işlem yapmaya geldi. 
- Projenin daha da genişleyebileceğini göz önüne ve veritabanına yapılcak işlemleri tek bir sınıftan yönetmek için alarak Generic Repository ve Unit Of Work sınıflarını kullandım. 

## Api Oluşturma

- Dışarıdan veritabanında değişiklik yapabilmesi için .Net Core Api kullandım. 
- Dependency injection yönetimini .Net Core da default olarak bulunan container ile yöneterek Swagger yardımı ile api controller'ları test ettim.

## Versiyon Yönetimi

- Projeyi sizinde alıp inceleyebilmeniz için git altyapısını kullanan github sitesine yükledim. Projeye  https://github.com/erdemcobanoglu/order-managment-api linkinden ulaşabilirsiniz.

## Faydalandığım Kaynaklar

- https://github.com/ 
- https://stackoverflow.com/
- https://www.restapitutorial.com/lessons/restfulresourcenaming.html/
- https://fluentvalidation.net/
- https://autofac.org/
