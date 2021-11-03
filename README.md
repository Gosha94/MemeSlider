# MemeSlider
Консольный переключатель Мемчиков
--
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
  
    docker pull gosha94/netcore:memeslider1.0
  
  2) Создаем контейнер из локального образа, сразу запускаем с командой, включающей имя мемосика (PokerFace) :
  
    docker run -it --rm --name MemeSliderContainer gosha94/netcore:memeslider1.0 PokerFace

Результат работы ниже:

![Image alt](https://github.com/Gosha94/MemeSlider/raw/master/src/MemeSlider.ConsoleApplication/Screenshots/ConsolePreview.png)

Swap right and enjoy!
