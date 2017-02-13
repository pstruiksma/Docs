Public Function Delete(ByVal fcNotUsed As FormCollection, Optional ByVal id As Integer = 0) As ActionResult
Dim movie As Movie = db.Movies.Find(id)
If movie Is Nothing Then
	Return HttpNotFound()
End If
db.Movies.Remove(movie)
db.SaveChanges()
Return RedirectToAction("Index")
End Function