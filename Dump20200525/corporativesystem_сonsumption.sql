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
-- Table structure for table `сonsumption`
--

DROP TABLE IF EXISTS `сonsumption`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `сonsumption` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Date` date NOT NULL,
  `Warehouse_id` int NOT NULL,
  `Client_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Сonsumption_Warehouse1_idx` (`Warehouse_id`),
  KEY `fk_Сonsumption_Client1_idx` (`Client_id`),
  CONSTRAINT `fk_Сonsumption_Client1` FOREIGN KEY (`Client_id`) REFERENCES `client` (`id`),
  CONSTRAINT `fk_Сonsumption_Warehouse1` FOREIGN KEY (`Warehouse_id`) REFERENCES `warehouse` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `сonsumption`
--

LOCK TABLES `сonsumption` WRITE;
/*!40000 ALTER TABLE `сonsumption` DISABLE KEYS */;
INSERT INTO `сonsumption` VALUES (1,'2020-02-22',1,1),(2,'2020-02-24',1,2),(3,'2020-02-26',1,3),(4,'2020-02-22',2,1),(5,'2020-02-24',2,2),(6,'2020-02-26',2,3),(7,'2020-02-22',3,1),(8,'2020-02-24',3,2),(9,'2020-02-26',3,3),(26,'2020-03-14',3,3),(27,'2020-03-15',2,1),(28,'2020-03-15',2,2),(29,'2020-05-06',2,3);
/*!40000 ALTER TABLE `сonsumption` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-25  0:55:19
