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
- Logging and Monitoring
- Performance analysis
- Debugging and Tracing
- Undo Functionality
- Validation of inputs and outputs
- Object Filters
- Security Implementation
- Managing transactions

## Verileri Kaydetme

- Json dosyası içerisindeki verileri veritabanına kaydetmek için uygun bir model oluşturup.
- EntityFramework yardımıile MsSql ile mapping yapıldı.

## Aspect-Oriented Programming’in Sağladıkları

- Veritabanına kayıt attıktan sonra sıra bu kayıtlar ve veritabanı üzerinden işlem yapmaya geldi. 
- İçi içe yazılmış ve sürekli tekrar eden kodlardan kurtulabiliyoruz,
- Daha temiz ve anlaşılır kodlar yazabiliyoruz,
- Yazmış olduğumuz kodları daha abstract hale getirerek modülerliğini arttırıyoruz,
- Bakım ve geliştirme maliyetlerini azaltıyoruz,
- Uygulamamızı daha yönetilebilir ve daha esnek hale getirebiliyoruz.

## Cross-Cutting Concerns
- AOP’nın ortaya çıkma sebeplerinden en önemlisi cross-cutting concern’lerdir. Cross-cutting corcernler , bir sistemin birden çok bölümünde kullanılan işlevsellik parçalarıdır. Cross-cutting corcernler AOP olmadan kodlandığı zaman fonksiyonel ihtiyaçlar ve fonksiyonel olmayan ihtiyaçlar birbirine karışır ve core logic ile cross-cutting concernler bir arada bulunur. Bu da kodu okunması daha zor bir hale sokar.

## Api Oluşturma

- Dışarıdan veritabanında değişiklik yapabilmesi için .Net Core Api kullandım. 
- Dependency injection yönetimini .Net Core da default olarak bulunan container ile yöneterek istenmesi halinde Swagger yardımı ile detaylı bir dökümantasyon ile api controller'ları test edilebilir.

## Api İstek Atma

- Örnek api isteği tekbir film değeri getirmek için https://localhost:44335/api/movie/getbyid?movieId=1  
- Bütün filmlere ulaşmak için ise https://localhost:44335/api/movie/getall linki kullanılmalıdır.  

## Versiyon Yönetimi

- Projeyi sizinde alıp inceleyebilmeniz için git altyapısını kullanan github sitesine yükledim. Projeye  https://github.com/erdemcobanoglu/MovieApp linkinden ulaşabilirsiniz.

## Faydalandığım Kaynaklar

- https://github.com/ 
- https://stackoverflow.com/
- https://www.restapitutorial.com/lessons/restfulresourcenaming.html/
- https://fluentvalidation.net/
- https://autofac.org/
