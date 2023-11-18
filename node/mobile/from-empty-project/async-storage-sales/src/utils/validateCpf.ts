export const validCpfs = ["11111111111", "22222222222", "33333333333"];

export const validateCpf = (cpf: string) => validCpfs.includes(cpf);