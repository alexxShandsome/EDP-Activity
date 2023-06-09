-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: edp_database
-- ------------------------------------------------------
-- Server version	8.0.30

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `post_categories`
--

DROP TABLE IF EXISTS `post_categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `post_categories` (
  `CATEGORY_ID` int NOT NULL AUTO_INCREMENT,
  `CATEGORY_NAME` text NOT NULL,
  `NUM_OF_POSTS` int DEFAULT '0',
  PRIMARY KEY (`CATEGORY_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `post_categories`
--

LOCK TABLES `post_categories` WRITE;
/*!40000 ALTER TABLE `post_categories` DISABLE KEYS */;
INSERT INTO `post_categories` VALUES (1,'Romance',1),(2,'Technology',1),(3,'Crytocurrency',0),(4,'Economics',0),(5,'Science Fiction',0),(6,'Fantasy',2),(7,'NSFW',2),(8,'Spice of Life',0),(9,'Comedy',2),(10,'Gaming',0),(11,'Celebrity',2);
/*!40000 ALTER TABLE `post_categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registered_users`
--

DROP TABLE IF EXISTS `registered_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registered_users` (
  `USER_ID` int NOT NULL AUTO_INCREMENT,
  `FIRST_NAME` varchar(50) NOT NULL,
  `LAST_NAME` varchar(50) NOT NULL,
  `USER_NAME` varchar(50) NOT NULL,
  `EMAIL` text NOT NULL,
  `PASSWORD` text NOT NULL,
  `GENDER` varchar(20) NOT NULL,
  `BIRTHDAY` date NOT NULL,
  `PROFILE_PIC` text NOT NULL,
  `BIO` text NOT NULL,
  PRIMARY KEY (`USER_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registered_users`
--

LOCK TABLES `registered_users` WRITE;
/*!40000 ALTER TABLE `registered_users` DISABLE KEYS */;
INSERT INTO `registered_users` VALUES (1,'Pedros','Penduko','encantadiaWarrio69','pedro_penduko@gmail.com','mahal kita maria','Male','2002-06-23','hehe.png','single ready to mingle'),(2,'Cardo','Dalisay','pilipinoCOD_life','cardo@gmail.com','cod iz ril layp','Male','1969-04-23','bangbang.png','bawal ang droga, patayin kita jan'),(3,'Chito','Miranda','idol ng Pinas','CHMiranda@gmail.com','neri naig','Male','1969-04-11','trending.png','sarap neto ah'),(4,'Wally','Bayola','TiradorNGDancer','WBayola@yahoo.com','wally is my name 123','Male','1979-12-11','trending2.png','basta eb babes alam na'),(5,'John','Cena','CantSeeMe','WBayola@yahoo.com','MyNameIsJohnCena','Male','2000-12-11','cantsee.png','you cant\' see me'),(6,'Dwayne','Johnson','The Rock','TheRock@gmail.com','Its about drive','Male','2000-12-11','rock.png','It\'s about drive, we stay hungry, we devour'),(7,'Patrick','Bateman','InsaneMan45','PaulAllen@gmail.com','I can\'t believe that bryce prefer paul\'s card','Male','2008-12-11','grind.png','My sanity is slipping away'),(8,'Algilbert','Gomez','yah~ yahyahyah~ tsahahaha','jepoydizon@gmail.com','hello world','Male','2002-08-20','hehe.png','onii-chan kimochii'),(9,'Lito','Lapid','english_iz_hard_af','lito_lapid@yahoo.com','helloo','Female','1989-12-07','bilis.jpeg','wag mo aq ingles inglesin'),(10,'James','Esparragoo','lessgo','jims@gmail.com','lezzgo','Female','1789-02-27','james.png','lezzgooo');
/*!40000 ALTER TABLE `registered_users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_downvote`
--

DROP TABLE IF EXISTS `user_downvote`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_downvote` (
  `DOWNVOTE_ID` int NOT NULL AUTO_INCREMENT,
  `USER_ID` int NOT NULL,
  `POST_ID` int NOT NULL,
  PRIMARY KEY (`DOWNVOTE_ID`),
  KEY `USER_ID` (`USER_ID`),
  KEY `POST_ID` (`POST_ID`),
  CONSTRAINT `User_Downvote_ibfk_1` FOREIGN KEY (`USER_ID`) REFERENCES `registered_users` (`USER_ID`),
  CONSTRAINT `User_Downvote_ibfk_2` FOREIGN KEY (`POST_ID`) REFERENCES `written_posts` (`POST_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_downvote`
--

LOCK TABLES `user_downvote` WRITE;
/*!40000 ALTER TABLE `user_downvote` DISABLE KEYS */;
INSERT INTO `user_downvote` VALUES (1,5,1),(2,4,2),(3,3,2),(4,1,3),(5,10,6),(6,9,6),(7,2,7),(8,3,7),(9,5,7),(10,9,10),(11,6,9),(12,8,9);
/*!40000 ALTER TABLE `user_downvote` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `user_posts`
--

DROP TABLE IF EXISTS `user_posts`;
/*!50001 DROP VIEW IF EXISTS `user_posts`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `user_posts` AS SELECT 
 1 AS `USER_ID`,
 1 AS `USER_NAME`,
 1 AS `POST_ID`,
 1 AS `TITLE`,
 1 AS `POST_IMAGE`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `user_upvote`
--

DROP TABLE IF EXISTS `user_upvote`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_upvote` (
  `UPVOTE_ID` int NOT NULL AUTO_INCREMENT,
  `USER_ID` int NOT NULL,
  `POST_ID` int NOT NULL,
  PRIMARY KEY (`UPVOTE_ID`),
  KEY `USER_ID` (`USER_ID`),
  KEY `POST_ID` (`POST_ID`),
  CONSTRAINT `User_Upvote_ibfk_1` FOREIGN KEY (`USER_ID`) REFERENCES `registered_users` (`USER_ID`),
  CONSTRAINT `User_Upvote_ibfk_2` FOREIGN KEY (`POST_ID`) REFERENCES `written_posts` (`POST_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_upvote`
--

LOCK TABLES `user_upvote` WRITE;
/*!40000 ALTER TABLE `user_upvote` DISABLE KEYS */;
INSERT INTO `user_upvote` VALUES (1,1,1),(2,2,1),(3,5,1),(4,6,2),(5,7,2),(6,3,3),(7,5,3),(8,2,3),(9,1,3),(10,10,3),(11,8,3),(12,4,3),(13,1,4),(14,2,4),(15,3,4),(16,6,4),(17,7,4),(18,4,5),(19,7,5),(20,7,6),(21,8,6),(22,5,6),(23,1,7),(24,2,7),(25,3,7),(26,4,7),(27,5,7),(28,6,7),(29,8,7),(30,9,7),(31,1,8),(32,2,8),(33,4,8),(34,5,8),(35,7,8),(36,9,8),(37,10,8),(38,3,8),(39,6,8),(40,6,9),(41,6,10),(42,7,10),(43,3,10),(44,8,10),(45,10,1),(46,4,10),(47,7,1),(48,9,1);
/*!40000 ALTER TABLE `user_upvote` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `who_downvote_my_post`
--

DROP TABLE IF EXISTS `who_downvote_my_post`;
/*!50001 DROP VIEW IF EXISTS `who_downvote_my_post`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `who_downvote_my_post` AS SELECT 
 1 AS `POST_ID`,
 1 AS `TITLE`,
 1 AS `USER_ID`,
 1 AS `USER_NAME`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `who_upvote_my_post`
--

DROP TABLE IF EXISTS `who_upvote_my_post`;
/*!50001 DROP VIEW IF EXISTS `who_upvote_my_post`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `who_upvote_my_post` AS SELECT 
 1 AS `POST_ID`,
 1 AS `TITLE`,
 1 AS `USER_ID`,
 1 AS `USER_NAME`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `written_posts`
--

DROP TABLE IF EXISTS `written_posts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `written_posts` (
  `POST_ID` int NOT NULL AUTO_INCREMENT,
  `USER_ID` int NOT NULL,
  `TITLE` text NOT NULL,
  `POST_IMAGE` text NOT NULL,
  `DATE_POSTED` date DEFAULT (curdate()),
  `CATEGORY_ID` int NOT NULL,
  `UPVOTE` int DEFAULT '0',
  `DOWNVOTE` int DEFAULT '0',
  PRIMARY KEY (`POST_ID`),
  KEY `Written_Posts_FK` (`USER_ID`),
  KEY `CATEGORY_ID` (`CATEGORY_ID`),
  CONSTRAINT `Written_Posts_FK` FOREIGN KEY (`USER_ID`) REFERENCES `registered_users` (`USER_ID`),
  CONSTRAINT `Written_Posts_ibfk_1` FOREIGN KEY (`CATEGORY_ID`) REFERENCES `post_categories` (`CATEGORY_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `written_posts`
--

LOCK TABLES `written_posts` WRITE;
/*!40000 ALTER TABLE `written_posts` DISABLE KEYS */;
INSERT INTO `written_posts` VALUES (1,3,'This is a title','post_image1.png','2002-05-23',7,8,1),(2,6,'It\'s about drive','post_image2.png','2020-05-03',7,4,2),(3,4,'EB BEBS','post_image3.png','2021-06-12',6,9,1),(4,5,'Cant See Me Bruh','post_image4.png','2008-12-25',11,7,0),(5,7,'really can\'t beleive','post_image5.png','1999-07-24',9,4,0),(6,5,'you really can\'t see me','post_image6.png','2021-06-05',6,5,2),(7,8,'hehe','post_image7.png','2021-07-14',9,10,3),(8,2,'stay in school kids','post_image8.jpeg','2000-02-14',11,11,0),(9,1,'patay dalawang tiktik','post_image9.jpg','2007-03-12',1,3,2),(10,10,'Nursing students the best','post_image10.webm','1898-03-02',2,7,1),(11,10,'BABY BABY OOOH','post_ni_jims.png','2023-02-17',7,0,0);
/*!40000 ALTER TABLE `written_posts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'edp_database'
--

--
-- Dumping routines for database 'edp_database'
--

--
-- Final view structure for view `user_posts`
--

/*!50001 DROP VIEW IF EXISTS `user_posts`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`algilbert`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `user_posts` AS select `registered_users`.`USER_ID` AS `USER_ID`,`registered_users`.`USER_NAME` AS `USER_NAME`,`written_posts`.`POST_ID` AS `POST_ID`,`written_posts`.`TITLE` AS `TITLE`,`written_posts`.`POST_IMAGE` AS `POST_IMAGE` from (`registered_users` join `written_posts`) where (`registered_users`.`USER_ID` = `written_posts`.`USER_ID`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `who_downvote_my_post`
--

/*!50001 DROP VIEW IF EXISTS `who_downvote_my_post`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`algilbert`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `who_downvote_my_post` AS select `written_posts`.`POST_ID` AS `POST_ID`,`written_posts`.`TITLE` AS `TITLE`,`user_downvote`.`USER_ID` AS `USER_ID`,`registered_users`.`USER_NAME` AS `USER_NAME` from ((`written_posts` join `user_downvote`) join `registered_users`) where ((`written_posts`.`POST_ID` = `user_downvote`.`POST_ID`) and (`user_downvote`.`USER_ID` = `registered_users`.`USER_ID`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `who_upvote_my_post`
--

/*!50001 DROP VIEW IF EXISTS `who_upvote_my_post`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`algilbert`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `who_upvote_my_post` AS select `written_posts`.`POST_ID` AS `POST_ID`,`written_posts`.`TITLE` AS `TITLE`,`user_upvote`.`USER_ID` AS `USER_ID`,`registered_users`.`USER_NAME` AS `USER_NAME` from ((`written_posts` join `user_upvote`) join `registered_users`) where ((`written_posts`.`POST_ID` = `user_upvote`.`POST_ID`) and (`user_upvote`.`USER_ID` = `registered_users`.`USER_ID`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-26 18:05:24
