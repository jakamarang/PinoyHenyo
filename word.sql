-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jan 14, 2013 at 09:02 AM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `phenyo`
--

-- --------------------------------------------------------

--
-- Table structure for table `word`
--

CREATE TABLE IF NOT EXISTS `word` (
  `Q1YES` varchar(50) CHARACTER SET utf8 NOT NULL,
  `Q1MAY` varchar(50) CHARACTER SET utf8 NOT NULL,
  `Q2YES` varchar(50) CHARACTER SET utf8 NOT NULL,
  `Q2MAY` varchar(50) CHARACTER SET utf8 NOT NULL,
  `Q3YES` varchar(50) CHARACTER SET utf8 NOT NULL,
  `Q3MAY` varchar(50) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `word`
--

INSERT INTO `word` (`Q1YES`, `Q1MAY`, `Q2YES`, `Q2MAY`, `Q3YES`, `Q3MAY`) VALUES
('', 'food', 'four-legged', 'herbivorous', 'gadget', ''),
('delicious', 'medium', 'land-based', 'carnivorous', 'picture', ''),
('fibrous', '', 'four legged', 'omnivorous', 'lens', ''),
('fruit', '', 'land based', '', 'chargeable', ''),
('grows in land', '', 'with tail', '', '', ''),
('hard', '', 'tailed', '', '', ''),
('juicy', 'desserts', 'domesticated', '', '', ''),
('land', '', 'mammal', '', '', ''),
('land based', '', 'hog', '', '', ''),
('need to peel', '', 'swine', '', '', ''),
('oval', 'small', 'food animal', '', '', ''),
('seedless', '', 'hairy', '', '', ''),
('sweet', 'pizza', 'heavy', '', '', ''),
('thick', '', 'rounded body', '', '', ''),
('thorny', 'large', '', '', '', ''),
('tropical', 'flavors', 'thick skin', '', '', ''),
('yellowish', '', 'fatty', '', '', ''),
('', '', 'meat', '', '', ''),
('', '', 'meat', '', '', ''),
('', '', 'animal', '', '', '');
