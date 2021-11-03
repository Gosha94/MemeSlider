# MemeSlider
Консольный слайдер мемов
<br>
На данный момент реализован просмотр Мемчиков ниже:
  1) Doge
  2) NyanCat
  3) OldSkull
  4) PokerFace
  5) RussianBear
  6) SurprisedCat
  7) Wall
Пример запуска приложения:
  1) Вытягиваем образ из DockerHub:
  <br>
  docker pull gosha94/netcore:memeslider1.0
  
Создаем локальный контейнер из образа в репозитории DockerHub:
docker run -it --rm --name MemeSliderContainer gosha94/netcore:memeslider1.0 PokerFace


![Image alt](https://github.com/Gosha94/MemeSlider/raw/master/src/MemeSlider.ConsoleApplication/Screenshots/ConsolePreview.png)
