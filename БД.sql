-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: kinopoisk
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `age_reiting`
--

DROP TABLE IF EXISTS `age_reiting`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `age_reiting` (
  `id_age_reiting` int NOT NULL,
  `Age_Rating_Film` varchar(45) NOT NULL,
  PRIMARY KEY (`id_age_reiting`),
  KEY `age_idx` (`id_age_reiting`,`Age_Rating_Film`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `age_reiting`
--

LOCK TABLES `age_reiting` WRITE;
/*!40000 ALTER TABLE `age_reiting` DISABLE KEYS */;
INSERT INTO `age_reiting` VALUES (1,'0+'),(2,'6+'),(3,'12+'),(4,'16+'),(5,'18+');
/*!40000 ALTER TABLE `age_reiting` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `film`
--

DROP TABLE IF EXISTS `film`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `film` (
  `ID_Film` int NOT NULL AUTO_INCREMENT,
  `Name_Film` varchar(45) NOT NULL,
  `Duration_Film` time NOT NULL,
  `Release_Date_Film` date NOT NULL,
  `Description_Film` varchar(1000) NOT NULL,
  `Image_Path_Film` varchar(100) DEFAULT NULL,
  `Videio_Path_Film` varchar(100) DEFAULT NULL,
  `Genre_Film` int DEFAULT NULL,
  `Age_Reiting` int NOT NULL,
  PRIMARY KEY (`ID_Film`),
  KEY `2_idx` (`Age_Reiting`),
  KEY `1_idx` (`Genre_Film`),
  CONSTRAINT `1` FOREIGN KEY (`Genre_Film`) REFERENCES `genre` (`ID_Genre`),
  CONSTRAINT `2` FOREIGN KEY (`Age_Reiting`) REFERENCES `age_reiting` (`id_age_reiting`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `film`
--

LOCK TABLES `film` WRITE;
/*!40000 ALTER TABLE `film` DISABLE KEYS */;
INSERT INTO `film` VALUES (1,'Рик и Морти','00:23:13','2013-12-02','В центре сюжета - школьник по имени Морти и его дедушка Рик. Морти - самый обычный мальчик, который ничем не отличается от своих сверстников. А вот его дедуля занимается необычными научными исследованиями и зачастую полностью неадекватен. Он может в любое время дня и ночи схватить внука и отправиться вместе с ним в безумные приключения с помощью построенной из разного хлама летающей тарелки, которая способна перемещаться сквозь межпространственный тоннель. Каждый раз эта парочка оказывается в самых неожиданных местах и самых нелепых ситуациях.','Rick_and_Morty.jpg','Rick_and_Morty_Video.mp4',2,5),(2,'Гравити Фолз','00:22:03','2012-06-15','История рассказывает о приключениях близнецов, брата и сестры Диппера и Мэйбл Пайнс, чьи летние планы отправляются в чулан, когда родители оправляют их к дальнему родственнику в тихий городок Гравити Фолз. Но так ли прост этот город, родственник и жители, и какие тайны ждут своих первооткрывателей?','Gravity_Falls.jpg','Gravity_Falls_Video.mp4',2,3),(3,'Человек-паук: Через вселенные ','01:57:26','2018-12-06','Мы всё знаем о Питере Паркере. Он спас город, влюбился, а потом спасал город снова и снова… Но все это – в нашем измерении. А что если в результате работы гигантского коллайдера откроется окно из одного измерения в другое? Найдется ли в нем свой Человек-паук? И как он будет выглядеть? Приготовьтесь к тому, что в разных вселенных могут быть разные Люди-пауки и однажды им придется собраться вместе для борьбы с почти непобедимым врагом.','Spider-Man_Into_the_Spider-Verse.jpg','Spider-Man_Into_the_Spider-Verse_Video.mp4',2,2),(4,'Криминальное чтиво','02:34:56','1994-05-21','Двое бандитов Винсент Вега и Джулс Винфилд ведут философские беседы в перерывах между разборками и решением проблем с должниками криминального босса Марселласа Уоллеса.','Pulp_Fiction.jpg','Pulp_Fiction_Video.mp4',12,5),(5,'Во все тяжкие','00:47:03','2008-01-20','Школьный учитель химии Уолтер Уайт узнаёт, что болен раком лёгких. Учитывая сложное финансовое состояние дел семьи, а также перспективы, Уолтер решает заняться изготовлением метамфетамина. Для этого он привлекает своего бывшего ученика Джесси Пинкмана, когда-то исключённого из школы при активном содействии Уайта. Пинкман сам занимался варкой мета, но накануне, в ходе рейда УБН, он лишился подельника и лаборатории.','Breaking_Bad.jpg','Breaking_Bad_Video.mp4',12,5),(6,'Друзья ','00:22:12','1994-09-22','Шестеро друзей – Рейчел, Моника, Фиби, Джоуи, Чендлер и Росс – живут по соседству, вместе убивают время, делятся секретами и иногда очень сильно влюбляются.','Friends.jpg','Friends_Video.mp4',1,4),(7,'Тайна Коко','01:45:42','2017-10-20','12-летний Мигель живёт в мексиканской деревушке в семье сапожников и тайно мечтает стать музыкантом. Тайно, потому что в его семье музыка считается проклятием. Когда-то его прапрадед оставил жену, прапрабабку Мигеля, ради мечты, которая теперь не даёт спокойно жить и его праправнуку. С тех пор музыкальная тема в семье стала табу. Мигель обнаруживает, что между ним и его любимым певцом Эрнесто де ла Крусом, ныне покойным, существует некая связь. Паренёк отправляется к своему кумиру в Страну Мёртвых, где встречает души предков. Мигель знакомится там с духом-скелетом по имени Гектор, который становится его проводником. Вдвоём они отправляются на поиски де ла Круса.','Coco.jpg','Coco_Video.mp4',2,3),(8,'Большой куш','01:44:12','2000-10-01','Фрэнки Четыре Пальца должен был переправить краденый алмаз из Англии в США своему боссу Эви, но, сделав ставку на подпольный боксерский поединок, он попал в круговорот весьма нежелательных событий. Вокруг него и его груза разворачивается сложная интрига с участием множества колоритных персонажей лондонского дна — русского гангстера, троих незадачливых грабителей, хитрого боксера и угрюмого громилы грозного мафиози. Каждый норовит в одиночку сорвать большой куш.','Snatch.jpg','Snatch_Video.mp4',12,5),(9,'Брат ','01:40:20','1997-05-17','Демобилизовавшись, Данила Багров вернулся в родной городок. Но скучная жизнь российской провинции не устраивала его, и он решился податься в Петербург, где, по слухам, уже несколько лет процветает его старший брат. Данила нашел брата. Но все оказалось не так просто — брат работает наемным убийцей.','Brother.jpg','Brother_Video.mp4',11,5),(10,'Ну, погоди!','00:10:33','1969-06-14','Веселые приключения неразлучной парочки - хулигана Волка и смышленого Зайца. Любимые с детства сцены погонь, ссор и примирений, шутки и мелодии.','Well_wait.jpg','Well_wait_Video.mp4',2,1),(18,'rtyuh','00:00:24','2020-12-21','srdftghjk','11ea73b02406f137742271272c2812e5.jpg','@dvachannel (3).mp4',3,3),(19,'sdfg','00:00:04','2022-12-31','dsfgnhhgearsdtxhfc','8f12565ae19a404ea4459437b5.jpg','doc_2023-05-09_19-57-19.mp4',3,5);
/*!40000 ALTER TABLE `film` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genre`
--

DROP TABLE IF EXISTS `genre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `genre` (
  `ID_Genre` int NOT NULL,
  `Genre_Film` varchar(45) NOT NULL,
  PRIMARY KEY (`ID_Genre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genre`
--

LOCK TABLES `genre` WRITE;
/*!40000 ALTER TABLE `genre` DISABLE KEYS */;
INSERT INTO `genre` VALUES (1,'Комедии'),(2,'Мультфильмы'),(3,'Ужасы'),(4,'Фантастика'),(5,'Триллеры'),(6,'Боевики'),(7,'Мелодрамы'),(8,'Детективы'),(9,'Приключения'),(10,'Фентези '),(11,'Драмы'),(12,'Криминал'),(13,'Биографии');
/*!40000 ALTER TABLE `genre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `id_Role` int NOT NULL,
  `Role` varchar(45) NOT NULL,
  PRIMARY KEY (`id_Role`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Администратор'),(2,'Клиент');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sub_status`
--

DROP TABLE IF EXISTS `sub_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sub_status` (
  `ID_Sub_Status` int NOT NULL,
  `SUB` varchar(45) NOT NULL,
  PRIMARY KEY (`ID_Sub_Status`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sub_status`
--

LOCK TABLES `sub_status` WRITE;
/*!40000 ALTER TABLE `sub_status` DISABLE KEYS */;
INSERT INTO `sub_status` VALUES (1,'Подписка'),(2,'Нет подписки');
/*!40000 ALTER TABLE `sub_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `ID_user` int NOT NULL AUTO_INCREMENT,
  `Surname_user` varchar(45) NOT NULL,
  `Name_user` varchar(45) NOT NULL,
  `Patronymic_user` varchar(45) DEFAULT NULL,
  `Login_user` varchar(45) NOT NULL,
  `Password_user` varchar(45) NOT NULL,
  `Role_user` int NOT NULL,
  `sub_status_user` int NOT NULL,
  `start_SUB_user` date DEFAULT NULL,
  `End_SUB_user` date DEFAULT NULL,
  PRIMARY KEY (`ID_user`),
  KEY `11_idx` (`Role_user`),
  KEY `22_idx` (`sub_status_user`),
  CONSTRAINT `11` FOREIGN KEY (`Role_user`) REFERENCES `role` (`id_Role`),
  CONSTRAINT `22` FOREIGN KEY (`sub_status_user`) REFERENCES `sub_status` (`ID_Sub_Status`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Зиннуров','Эмиль','Ильдарович','qwe','123',1,1,'2022-11-28','2077-12-31'),(2,'Умиленов','Богдан','Андреевич','zxc','111',1,1,'2023-01-20','2023-02-20'),(3,'Лиханов','Дмитрий','Ликс','Lixxx','321',2,2,'2023-02-22','2023-03-22'),(4,'Биг','Бон','Бумыч','ghoul','zxc',2,2,'2022-12-06','2023-01-06'),(5,'Будапешт','Гранд','Алексеевич','qwe','111',2,2,'2022-12-07','2023-01-07'),(6,'Братишкин','Владимир','Лох','Brff','8989',2,2,'2022-12-08','2023-01-08'),(7,'Иванов','Иван','Иванович','IvanZolo2004','321',2,2,'2022-12-10','2023-01-10'),(8,'xc','xvcx','sd','1','q',2,2,'2022-12-12','2023-01-12');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-07-03 20:00:17
