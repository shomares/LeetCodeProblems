/**
 * Definition for singly-linked list.
 * class ListNode {
 *     val: number
 *     next: ListNode | null
 *     constructor(val?: number, next?: ListNode | null) {
 *         this.val = (val===undefined ? 0 : val)
 *         this.next = (next===undefined ? null : next)
 *     }
 * }
 */

import { ListNode } from "./listNode";
import { createNodeList } from "./reverseBetween";

//1, 2, 3, 4, 5,6
function oddEvenList(head: ListNode | null): ListNode | null {
    if(head === null){
        return null
    }
    const headOdd = head
    const headEven = head.next
    let odd = head
    let even = head.next

    while (even != null && odd != null) {
        odd.next = odd.next != null ? odd.next.next : null
        even.next = even.next != null ? even.next.next : null
        odd = odd.next
        even = even.next
    }

    odd = headOdd

    while (odd.next != null) {
        odd = odd.next
    }

    odd.next = headEven

    return headOdd
};

function printList(head: ListNode | null) {

    if (head === null) {
        return
    }

    console.log(head.val)
    printList(head.next)

}

const s = oddEvenList(createNodeList([1, 2, 3, 4, 5, 6]))
printList(s)