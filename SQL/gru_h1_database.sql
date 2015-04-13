-- phpMyAdmin SQL Dump
-- version 4.0.8
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 25, 2015 at 12:40 PM
-- Server version: 5.6.14-log
-- PHP Version: 5.4.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `gru_h1_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `blogs`
--

CREATE TABLE IF NOT EXISTS `blogs` (
  `BlogID` int(11) NOT NULL AUTO_INCREMENT,
  `BlogTitle` varchar(255) NOT NULL,
  `BlogDesc` longtext NOT NULL,
  `BlogsCont` longtext NOT NULL,
  `BlogDate` datetime NOT NULL,
  PRIMARY KEY (`BlogID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Phone` varchar(255) DEFAULT NULL,
  `isAdmin` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `Username`, `Password`, `Email`, `Phone`, `isAdmin`) VALUES
(1, 'Gaben123', 'Gaben', 'haraldurloki@gmail.com', '6661337', 1);

-- --------------------------------------------------------

--
-- Table structure for table `users_has_blogs`
--

CREATE TABLE IF NOT EXISTS `users_has_blogs` (
  `Users_BlogsID` int(11) NOT NULL AUTO_INCREMENT,
  `Blogs_BlogID` int(11) DEFAULT NULL,
  `Users_UserID` int(11) DEFAULT NULL,
  PRIMARY KEY (`Users_BlogsID`),
  KEY `fk_Blogs_has_Users_Users1_idx` (`Users_UserID`),
  KEY `fk_Blogs_has_Users_Blogs_idx` (`Blogs_BlogID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `users_has_blogs`
--
ALTER TABLE `users_has_blogs`
  ADD CONSTRAINT `fk_Blogs_has_Users_Blogs` FOREIGN KEY (`Blogs_BlogID`) REFERENCES `blogs` (`BlogID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Blogs_has_Users_Users1` FOREIGN KEY (`Users_UserID`) REFERENCES `users` (`UserID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
