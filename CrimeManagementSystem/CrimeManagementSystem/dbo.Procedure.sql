CREATE PROCEDURE [dbo].INSERTSP
	@param1 varchar(100),
	@param2 varchar(100),
	@param3 varchar(100)
AS
	insert into  Complaints([Complaint No.] , Name , Date) values(@param1 , @param2 , @param3)
RETURN 0
