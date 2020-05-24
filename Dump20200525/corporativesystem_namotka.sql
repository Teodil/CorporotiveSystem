-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: corporativesystem
-- ------------------------------------------------------
-- Server version	8.0.19

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
-- Table structure for table `namotka`
--

DROP TABLE IF EXISTS `namotka`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `namotka` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Length` double DEFAULT NULL,
  `Number` varchar(45) DEFAULT NULL,
  `Katyshka_Id` int NOT NULL,
  `Product_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Namotka_Katyshka1_idx` (`Katyshka_Id`),
  KEY `fk_Namotka_Product1_idx` (`Product_id`),
  CONSTRAINT `fk_Namotka_Katyshka1` FOREIGN KEY (`Katyshka_Id`) REFERENCES `katyshka` (`Id`),
  CONSTRAINT `fk_Namotka_Product1` FOREIGN KEY (`Product_id`) REFERENCES `product` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `namotka`
--

LOCK TABLES `namotka` WRITE;
/*!40000 ALTER TABLE `namotka` DISABLE KEYS */;
INSERT INTO `namotka` VALUES (11,300,'1-2',2,1),(12,150,'1-3',3,1),(13,100,'2-1',4,2),(16,100,'3-1',7,3),(17,550,'3-2',8,3),(20,250,'3-3',11,3),(21,500,'2-3',12,1),(22,600,'3-4',13,1);
/*!40000 ALTER TABLE `namotka` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-25  0:55:20
