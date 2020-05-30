import { trigger, style, query, group, animate, keyframes, transition } from '@angular/animations';
export const fadeAnimation = trigger('fadeAnimation', [
    transition('* <=> *', [
        query(":enter", [
            style([{ opacity: 0 }])
        ], { optional: true }),
        query(":leave", [
            style([{ opacity: 1 }]), animate('0.2s', style({ opacity: 0 }))
        ], { optional: true }),
        query(':enter', [style({ opacity: 0 }), animate('0.2s', style({ opacity: 1 }))], { optional: true })
    ])
]);
export const zoomInOut = trigger('zoomInOut', [
    transition('* <=> *', [
        group([
            query(':enter', [
                animate('0.5s ease', keyframes([
                    style({ opacity: 0, transform: 'scale3d(0.5, 0.5, 0.5)', offset: 0 }),
                    style({ opacity: 0.5, transform: 'scale3d(0.75, 0.75, 0.75)', offset: 0.5 }),
                    style({ opacity: 1, transform: 'scale3d(1, 1, 1)', offset: 1 })
                ]))
            ], { optional: true })
        ])
    ])
]);
//# sourceMappingURL=route-animations.js.map