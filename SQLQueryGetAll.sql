
-- =============================================
-- Author:      <Author, , Name>
-- Create Date: <Create Date, , >
-- Description: <Description, , >
-- =============================================

alter procedure dbo.spPersontabell_GetAll
as
begin
	set nocount on;
	select ID, Fornavn, Mellomnavn, Etternavn, Adresse1, Adresse2, Adresse3, Adresse4, Adresse5, 
		Postnummer1, Postnummer2, Postnummer3, Postnummer4, Postnummer5, Poststed1, Poststed2, Poststed3,
		Poststed4, Poststed5, Email1, Email2, Email3, Email4, Email5
	from dbo.Persontabell;
end