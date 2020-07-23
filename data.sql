CREATE TABLE Project (
    PID INT PRIMARY KEY,
    Title varchar(255) NOT NULL,
    Description varchar(255)
);
CREATE TABLE ProjectTask (
    ID INT PRIMARY KEY,
    Title varchar(255) NOT NULL,
    CONSTRAINT fk_group FOREIGN KEY (PID)
       REFERENCES Project(PID),
    Hours varchar(255)
);
INSERT INTO Project(PId, Title, Description)
VALUES(1,	'GVT Project 1',	'GVT Project Description - 1'),
(2,	'GVT Project 2',	'GVT Project Description - 2'),
(3,	'GVT Project 3',	'GVT Project Description - 3')
(4,	'GVT Project 4',	'GVT Project Description - 4');

INSERT INTO ProjectTask(PId,Title,PId,Hours)
VALUES(1,	'GVT Task 1',	1,	20),
(2,	'GVT Project 2',	'GVT Project Description - 2'),
(3,	'GVT Project 3',	'GVT Project Description - 3')
(4,	'GVT Project 4',	'GVT Project Description - 4');
