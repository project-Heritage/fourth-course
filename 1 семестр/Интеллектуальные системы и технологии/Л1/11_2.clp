(deffunction ask-question (?question $?allowed-values)
(printout t ?question)
(bind ?answer (read))
(if (lexemep ?answer)
then
(bind ?answer (lowcase ?answer)))
(while (not (member ?answer ?allowed-values)) do
(printout t ?question)
(bind ?answer (read))
(if (lexemep ?answer)
then
(bind ?answer (lowcase ?answer))))
?answer
)

(deffunction yes-or-no-p (?question)
(bind ?response (ask-question ?question yes no y n))
(if (or (eq ?response yes) (eq ?response y))
then TRUE
else FALSE)
)

(defrule hochesh-kushat ""
(not (state ?))
(not (repair ?))
=>
(if (yes-or-no-p " Do you want to eat (yes/no)?")
then
(assert (state da))
else
(assert (state net)))
)


(defrule hochesh-kushat2 ""
(state net)
(not (repair ?))
=>
(assert (repair "Tell me how you want to eat"))
)



(defrule hochesh-kushat3 ""
(state da)
(not (state1 ?))
(not (repair ?))
=>
(if (yes-or-no-p " Soup? (yes/no)?")
then
(assert (state1 da))
else
(assert (state1 net)))
)


(defrule hochesh-kushat4 ""
(state da)
(state1 da)
(not (state2 ?))
(not (repair ?))
=>
(if (yes-or-no-p " Cook it quickly? (yes/no)?")
then
(assert (state2 da))
else
(assert (state2 net)))
)

(defrule hochesh-kushat5 ""
(state da)
(state1 da)
(state2 da)
(not (repair ?))
=>
(if (yes-or-no-p " Got any sausages? (yes/no)?")
then
(assert (repair "Noodle soup with sausages"))
else
(assert (repair "Eat dumplings or noodles")))
)

(defrule hochesh-kushat6 ""
(state da)
(state1 da)
(state2 net)
(not (state3 ?))
(not (repair ?))
=>
(if (yes-or-no-p " With meat? (yes/no)?")
then
(assert (state3 da))
else
(assert (repair "Simple cream soup with potatoes")))
)

(defrule hochesh-kushat7 ""
(state da)
(state1 da)
(state2 net)
(state3 da)
(not (state4 ?))
(not (repair ?))
=>
(if (yes-or-no-p " With a chicken? (yes/no)?")
then
(assert (repair "Soup with potatoes and chicken"))
else
(assert (state4 net)))
)

(defrule hochesh-kushat8 ""
(state da)
(state1 da)
(state2 net)
(state3 da)
(state4 net)
(not (state5 ?))
(not (repair ?))
=>
(if (yes-or-no-p " With beef? (yes/no)?")
then
(assert (repair "Cabbage soup with beef and cabbage"))
else
(assert (state5 net)))
)

(defrule hochesh-kushat9 ""
(state da)
(state1 da)
(state2 net)
(state3 da)
(state4 net)
(state5 net)
(not (state6 ?))
(not (repair ?))
=>
(if (yes-or-no-p " With pork? (yes/no)?")
then
(assert (repair "Pork kharcho with rice"))
else
(assert (state6 net)))
)

(defrule hochesh-kushat10 ""
(state da)
(state1 da)
(state2 net)
(state3 da)
(state4 net)
(state5 net)
(state6 net)
(not (repair ?))
=>
(if (yes-or-no-p " With mutton? (yes/no)?")
then
(assert (repair "Mutton buchler"))
else
(assert (repair "Trout fish soup")))
)

(defrule hochesh-kushat11 ""
(state da)
(state1 net)
(not (state7 ?))
(not (repair ?))
=>
(if (yes-or-no-p " Anything with potatoes? (yes/no)?")
then
(assert (state7 da))
else
(assert (state7 net)))
)


(defrule hochesh-kushat12 ""
(state da)
(state1 net)
(state7 da)
(not (state8 ?))
(not (repair ?))
=>
(if (yes-or-no-p " Shall we fry? (yes/no)?")
then
(assert (state8 da))
else
(assert (state8 net)))
)

(defrule hochesh-kushat13 ""
(state da)
(state1 net)
(state7 da)
(state8 da)
(not (state9 ?))
(not (repair ?))
=>
(if (yes-or-no-p " With meat? (yes/no)?")
then
(assert (repair "Pork with potatoes in a pan"))
else
(assert (state9 net)))
)

(defrule hochesh-kushat14 ""
(state da)
(state1 net)
(state7 da)
(state8 da)
(state9 net)
(not (repair ?))
=>
(if (yes-or-no-p " With vegetables? (yes/no)?")
then
(assert (repair "Fried potatoes with vegetables"))
else
(assert (repair "Fried potatoes with mushrooms")))
)

(defrule hochesh-kushat15 ""
(state da)
(state1 net)
(state7 da)
(state8 net)
(not (state10 ?))
(not (repair ?))
=>
(if (yes-or-no-p " Will we put out? (yes/no)?")
then
(assert (state10 da))
else
(assert (repair "Pureshka")))
)

(defrule hochesh-kushat16 ""
(state da)
(state1 net)
(state7 da)
(state8 net)
(state10 da)
(not (state11 ?))
(not (repair ?))
=>
(if (yes-or-no-p " With meat? (yes/no)?")
then
(assert (repair "Braised potatoes with pork"))
else
(assert (state11 net)))
)

(defrule hochesh-kushat17 ""
(state da)
(state1 net)
(state7 da)
(state8 net)
(state10 da)
(state11 net)
(not (repair ?))
=>
(if (yes-or-no-p " With vegetables? (yes/no)?")
then
(assert (repair "Stewed potatoes with vegetables"))
else
(assert (repair "Stewed potatoes with mushrooms")))
)

(defrule hochesh-kushat18 ""
(state da)
(state1 net)
(state7 net)
(not (state12 ?))
(not (repair ?))
=>
(if (yes-or-no-p " Macaroni? (yes/no)?")
then
(assert (state12 da))
else
(assert (repair "Make a sandwich")))
)

(defrule hochesh-kushat19 ""
(state da)
(state1 net)
(state7 net)
(state12 da)
(not (repair ?))
=>
(if (yes-or-no-p " With meat? (yes/no)?")
then
(assert (repair "Pasta with meat"))
else
(assert (repair "Pasta with coarse grains and vegetables")))
)

(defrule system-banner ""
 (declare (salience 10))
 =>
 (printout t crlf crlf)
 (printout t "AUTOEXPERT")
 (printout t crlf crlf)
)


(defrule print-repair ""
 (declare (salience 10))
 (repair ?item)
 =>
 (printout t crlf crlf)
 (printout t "Recommendation:")
 (printout t crlf crlf)
 (format t " %s%n%n%n" ?item)
)

