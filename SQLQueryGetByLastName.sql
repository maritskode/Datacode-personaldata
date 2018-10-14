
-- =============================================
-- Author:      <Author, Marit Irene Sandanger,>
-- Create Date: <Create Date, 10.10.2018, >
-- Description: <Description, The procedure searches and returns all coloumns of values of 
--               the person or persons that have Etternavn equal the @LastName inparameter, >
-- =============================================

create procedure dbo.spPersontabell_GetByLastName
	@LastName nvarchar(50)
as
begin
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    set nocount on;

	select ID, Fornavn, Mellomnavn, Etternavn, Adresse1, Adresse2, Adresse3, Adresse4, Adresse5,
		Postnummer1, Postnummer2, Postnummer3, Postnummer4, Postnummer5, Poststed1, Poststed2,
		Poststed3, Poststed4, Poststed5, Email1, Email2, Email3, Email4, Email5
	from dbo.Persontabell
	where Etternavn = @LastName
end



