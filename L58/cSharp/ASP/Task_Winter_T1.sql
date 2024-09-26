SELECT k.kunden_id, k.firma, k.email
FROM kunden k
WHERE k.firma like 'M%'
ORDER BY k.kunden_id ASC;

