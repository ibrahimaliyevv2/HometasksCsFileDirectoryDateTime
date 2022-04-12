# HometasksCsFileDirectoryDateTime

Tapşırıq:
Meeting class:
-FromDate - Meetingin başlama tarixini bildirir
-ToDate - Meetingin bitmə  tarixini bildirir
-Name - Meetigin adını bildirir
 
MeetingSchedule class:
Meetings - Meeting listi
SetMeeting(fullname,from,to) - göndərilmiş dəyərlərə əsasən meeting yaratmağa çalışır.
                                                      Əgər Göndərilmiş tarix intervalında meeting varsaException baş verir
                                                      hər şey okaydirsə meeting obyekti yaradıb meeting listinə add edir.



FindMeetingsCount() - bu metod  parametr olaraq datetime qəbul edir və həmin date-dən sonra başlayan meetinglərin sayını qaytarır



IsExistsMeetingByName() - bu metod parametr olaraq string qəbul edir və əgər meetings listində hansısa meetingin name dəyərində parametr olaraq göndərilən string dəyər varsa  true, yoxdursa false qaytarır



GetExistMeetings() - bu metod parametr oıaraq name dəyəri qəbul edir və əgər meetings listində adında həmin dəyər olan meetinglerdən ibarət list qaytarır


Qeyd: Metodları yazarkən  Listin var olan metodlarından istifadə etməyə çalışın
