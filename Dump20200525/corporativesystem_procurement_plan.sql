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
-- Table structure for table `procurement_plan`
--

DROP TABLE IF EXISTS `procurement_plan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `procurement_plan` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Execution_Date` date NOT NULL,
  `Amount_For_Plane` int DEFAULT NULL,
  `Responsible` varchar(255) DEFAULT NULL,
  `Product_id` int NOT NULL,
  `status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Procurement_Product1_idx` (`Product_id`),
  CONSTRAINT `fk_Procurement_Product1` FOREIGN KEY (`Product_id`) REFERENCES `product` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `procurement_plan`
--

LOCK TABLES `procurement_plan` WRITE;
/*!40000 ALTER TABLE `procurement_plan` DISABLE KEYS */;
INSERT INTO `procurement_plan` VALUES (1,'2020-02-23',300,'Голядинец',1,'Заказан'),(2,'2020-03-07',500,'Голядинец',1,'Заказан'),(3,'2020-03-15',600,'Голядинец',1,'Заказан'),(4,'2020-02-23',300,'Живоглядов',2,'Заказан'),(5,'2020-03-07',500,'Живоглядов',2,'Не заказан'),(6,'2020-03-15',600,'Живоглядов',2,'Не заказан'),(7,'2020-03-15',150,'Сабиор',3,'Не заказан'),(8,'2020-03-15',350,'Сабиор',3,'Заказан'),(9,'2020-03-15',100,'Сабиор',3,'Заказан'),(10,'2020-05-17',228,'Голядинец',1,'Не заказан'),(11,'2020-05-26',322,'Сабиров',1,'Не заказан'),(12,'2020-05-18',500,'Голядинец',2,'Не заказан'),(13,'2020-05-20',600,'Голядинец',1,'Заказан');
/*!40000 ALTER TABLE `procurement_plan` ENABLE KEYS */;
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
