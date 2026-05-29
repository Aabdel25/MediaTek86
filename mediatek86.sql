-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 28 mai 2026 à 16:31
-- Version du serveur : 8.4.7
-- Version de PHP : 8.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--
CREATE DATABASE IF NOT EXISTS `mediatek86` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE `mediatek86`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(1, '2024-01-02 00:00:00', '2024-01-05 00:00:00', 1),
(2, '2024-01-08 00:00:00', '2024-01-09 00:00:00', 2),
(3, '2024-01-15 00:00:00', '2024-01-19 00:00:00', 1),
(4, '2024-01-22 00:00:00', '2024-01-23 00:00:00', 3),
(5, '2024-01-29 00:00:00', '2024-02-02 00:00:00', 1),
(6, '2024-02-05 00:00:00', '2024-02-07 00:00:00', 2),
(7, '2024-02-12 00:00:00', '2024-02-16 00:00:00', 1),
(8, '2024-02-19 00:00:00', '2024-02-19 00:00:00', 2),
(9, '2024-02-26 00:00:00', '2024-02-28 00:00:00', 3),
(10, '2024-03-04 00:00:00', '2024-03-08 00:00:00', 1),
(1, '2024-03-11 00:00:00', '2024-03-12 00:00:00', 2),
(3, '2024-03-18 00:00:00', '2024-03-22 00:00:00', 1),
(5, '2024-03-25 00:00:00', '2024-03-26 00:00:00', 4),
(2, '2024-04-01 00:00:00', '2024-04-05 00:00:00', 1),
(4, '2024-04-08 00:00:00', '2024-04-09 00:00:00', 2),
(6, '2024-04-15 00:00:00', '2024-04-19 00:00:00', 1),
(7, '2024-04-22 00:00:00', '2024-04-23 00:00:00', 3),
(8, '2024-04-29 00:00:00', '2024-04-30 00:00:00', 2),
(9, '2024-05-06 00:00:00', '2024-05-10 00:00:00', 1),
(10, '2024-05-13 00:00:00', '2024-05-14 00:00:00', 2),
(1, '2024-05-20 00:00:00', '2024-05-24 00:00:00', 1),
(3, '2024-05-27 00:00:00', '2024-05-29 00:00:00', 2),
(5, '2024-06-03 00:00:00', '2024-06-07 00:00:00', 1),
(2, '2024-06-10 00:00:00', '2024-06-13 00:00:00', 2),
(4, '2024-06-17 00:00:00', '2024-06-21 00:00:00', 1),
(6, '2024-06-24 00:00:00', '2024-06-25 00:00:00', 2),
(7, '2024-07-01 00:00:00', '2024-07-12 00:00:00', 1),
(8, '2024-07-08 00:00:00', '2024-07-09 00:00:00', 2),
(9, '2024-07-15 00:00:00', '2024-07-19 00:00:00', 1),
(10, '2024-07-22 00:00:00', '2024-07-26 00:00:00', 1),
(1, '2024-07-29 00:00:00', '2024-07-30 00:00:00', 3),
(3, '2024-08-05 00:00:00', '2024-08-09 00:00:00', 4),
(5, '2024-08-12 00:00:00', '2024-08-16 00:00:00', 1),
(2, '2024-08-19 00:00:00', '2024-08-20 00:00:00', 2),
(4, '2024-08-26 00:00:00', '2024-08-30 00:00:00', 1),
(6, '2024-09-02 00:00:00', '2024-09-03 00:00:00', 2),
(7, '2024-09-09 00:00:00', '2024-09-13 00:00:00', 1),
(8, '2024-09-16 00:00:00', '2024-09-17 00:00:00', 3),
(9, '2024-09-23 00:00:00', '2024-09-27 00:00:00', 1),
(10, '2024-10-07 00:00:00', '2024-10-11 00:00:00', 2),
(1, '2024-10-14 00:00:00', '2024-10-18 00:00:00', 1),
(3, '2024-10-21 00:00:00', '2024-10-22 00:00:00', 2),
(5, '2024-10-28 00:00:00', '2024-11-01 00:00:00', 1),
(2, '2024-11-04 00:00:00', '2024-11-07 00:00:00', 3),
(4, '2024-11-11 00:00:00', '2024-11-15 00:00:00', 1),
(6, '2024-11-18 00:00:00', '2024-11-19 00:00:00', 2),
(7, '2024-11-25 00:00:00', '2024-11-29 00:00:00', 1),
(8, '2024-12-02 00:00:00', '2024-12-03 00:00:00', 2),
(9, '2024-12-09 00:00:00', '2024-12-13 00:00:00', 1),
(10, '2024-12-16 00:00:00', '2024-12-17 00:00:00', 3);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'Vacances'),
(2, 'Maladie'),
(3, 'Motif familial'),
(4, 'Congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Martin', 'Sophie', '0549123456', 'sophie.martin@email.fr', 1),
(2, 'Bernard', 'Luc', '0549234567', 'luc.bernard@gmail.com', 2),
(3, 'Dupont', 'Marie', '0549345678', 'marie.dupont@email.fr', 3),
(4, 'Leclerc', 'Thomas', '0549456789', 'thomas.leclerc@gmail.com', 1),
(5, 'Moreau', 'Julie', '0549567890', 'julie.moreau@email.fr', 2),
(6, 'Simon', 'Pierre', '0549678901', 'pierre.simon@gmail.com', 3),
(7, 'Laurent', 'Camille', '0549789012', 'camille.laurent@email.fr', 1),
(8, 'Michel', 'Antoine', '0549890123', 'antoine.michel@gmail.com', 2),
(9, 'Garcia', 'Isabelle', '0549901234', 'isabelle.garcia@email.fr', 3),
(10, 'Robert', 'Francois', '0549012345', 'francois.robert@gmail.com', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('admin', '059a50ce956b7ec61527c7ecc0c55b5a009dc54ab4acddce8852b46baa2aba30');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'Administratif'),
(2, 'Médiation culturelle'),
(3, 'Prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
