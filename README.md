# HometasksCsOOPAbstractionAndInterface

C# Abstraction (detail hiding) ,Abstract keyword,Interface

1.  Aşağıdakı parametrlərdən ibarət Vehicle class-ı yaradırsınız
    - Color
    - Brand
    - Millage - bu vaxta qədər getmiş olduğu məsafəni ifadə edir (km olaraq)
    - ShowInfo() - bu metod virtualdır və console-a brand,color və millage yazdırır
  
   
    Car və Bycle clasları yaradırsınız, hər bir class-a Vehicle classını miras verirsiniz.Carın əlavə olaraq FuelCapacity ,CurrentFuel, FuelFor1km fieldləri var. Drive metodu car üzərində istifadə olunduqda birinci var olan benzin miqdarı ilə bu məsafəninin gedilib gedilə bilməyəcəyi yoxlanmalıdır, daha sonra əgər gedilə bilərsə benzin azalmalı və millage artmalıdır.Bycle classında isə Drive olunduqda millage artmalıdır


Layihə run olanda sizdən car sayını daxil etməyinizi istəyir, daha sonra həmin qədər car üçün lazımlı dataları sizdən istəyir və yekunda bir car arrayi formalasdırmış olmalısınız.Car arrayı formalaşandan sonra istifadəçinin qarşısına aşagıdaki menu çıxır
1. Maşınları millage-e göre filtirlə
2. Bütün maşınları göstər
3. Prosesi bitir


1 seçilərsə millage üçün min və max dəyərleri daxil edilir və millage dəyəri həmin aralıqda olan bütün maşınlar göstərilir
2 

seçilərsə  bütün masin dataları göstərilir
3 

seçilərsə  proqram bitir
