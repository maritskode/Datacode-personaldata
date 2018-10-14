
-- =============================================
-- Author:      <Author, Marit Irene Sandanger,>
-- Create Date: <Create Date, 12.10.2018, >
-- Description: <Description, The procedure searches through the dbo.Persontabell and returns all coloumns of 
--               the person(s) that have Postnummer equal to the @Postnumber inparameter
-- =============================================

create procedure dbo.spPersontabell_GetByPostnumber
	@Postnumber int
as
begin
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    set nocount on;

	select ID, Fornavn, Mellomnavn, Etternavn, Adresse1, Adresse2, Adresse3, Adresse4, Adresse5,
		Postnummer1, Postnummer2, Postnummer3, Postnummer4, Postnummer5, Poststed1, Poststed2,
		Poststed3, Poststed4, Poststed5, Email1, Email2, Email3, Email4, Email5
	from dbo.Persontabell
	where (Postnummer1 = @Postnumber or Postnummer2 = @Postnumber
			or Postnummer3 = @Postnumber or Postnummer4 = @Postnumber or Postnummer5 = @Postnumber)
end



