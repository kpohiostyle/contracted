CREATE TABLE jobs(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name VARCHAR(255) NOT NULL,
  description VARCHAR (255) NOT NULL COMMENT 'Job Description',
  payOut INT NOT NULL COMMENT 'Pay per Job'
);
CREATE TABLE contractors (
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name VARCHAR (255) NOT NULL,
  skill VARCHAR (255) NOT NULL COMMENT "Contrator Expertise"
);
CREATE TABLE contractor_jobs(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  jobId int NOT NULL COMMENT 'FK: Jobs Relationship',
  contractorId INT NOT NULL COMMENT 'FK: Contractors Relationship',
  FOREIGN KEY (jobId) REFERENCES jobs(id) ON DELETE CASCADE,
  FOREIGN KEY (contractorId) REFERENCES contractors(id) ON DELETE CASCADE
);
SELECT
  j.*,
  c.skill c.name as contratorName,
  cj.id as contractorjobId,
  cj.jobId as jobId,
  cj.contractorId as contractorId
FROM
  contractor_jobs cj
  JOIN jobs j ON j.id = cj.jobId
  JOIN contractors c ON c.id = cj.contractorId
WHERE
  cj.contractorId = @id